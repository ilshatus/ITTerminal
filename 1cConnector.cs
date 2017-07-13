
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Configuration;

namespace ITTerminal
{
    class Connector1C
    {
        static string orgName = ConfigurationManager.ConnectionStrings["OrgName"].ConnectionString;
        static string stockName = ConfigurationManager.ConnectionStrings["stockName"].ConnectionString;
        static string login = ConfigurationManager.ConnectionStrings["login"].ConnectionString;
        static string password = ConfigurationManager.ConnectionStrings["password"].ConnectionString;
        static string page = ConfigurationManager.ConnectionStrings["ConnectionToBase"].ConnectionString;

        /// <summary>
        /// This method moves equipment from one place to another. All the parameters must be given as a string
        /// and must be exactly as in 1c base.
        /// </summary>
        /// <param name="orgFrom">from which organization</param>
        /// <param name="orgTo">to which organization</param>
        /// <param name="placeFrom">from which place</param>
        /// <param name="placeTo">to which place</param>
        /// <param name="equipmentID">(inventory number = barcode) of equipment</param>
        /// <returns>string containing number of movement or text of reason of error</returns>
        private static bool moveEquipment(string orgFrom, string orgTo, string placeFrom, string placeTo, string equipmentID)
        {
            StringBuilder requestString = new StringBuilder(page + "hs/move/");
            requestString.Append(orgFrom);
            requestString.Append("/");
            requestString.Append(orgTo);
            requestString.Append("/");
            requestString.Append(placeFrom);
            requestString.Append("/");
            requestString.Append(placeTo);
            requestString.Append("/");
            requestString.Append(equipmentID);

            WebRequest request = WebRequest.Create(requestString.ToString());

            request.Credentials = new System.Net.NetworkCredential(login, password);

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception exception)
            {
                return false;
            }

            /*Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();*/
            response.Close();
            return true;
        }

        /// <summary>
        /// This method gets equipment ID as a parameter and returns filled Equipment class.
        /// </summary>
        /// <param name="ID">(inventory number = barcode) of equipment</param>
        /// <returns>Equipment class if this equipment is in base and no errors occured, null - otherwise.</returns>
        public static Equipment getEquipmentByID(string ID)
        {
            StringBuilder requestString = new StringBuilder(page + "hs/equipmentInfo/" + ID);

            WebRequest request = WebRequest.Create(requestString.ToString());

            request.Credentials = new System.Net.NetworkCredential("1cTeam1", "k&jH32!4qS");

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException exception)
            {
                return null;
            }

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string placeType = streamReader.ReadLine();
            if (placeType.Equals("No such equipment"))
                return null;
            string name = streamReader.ReadLine();
            string type = streamReader.ReadLine();
            string serial = streamReader.ReadLine();

            response.Close();
            stream.Close();
            streamReader.Close();
            if (placeType.Equals("Склад"))
                return new Equipment(name, type, ID, serial);
            else
                return null;
        }

        /// <summary>
        /// This method gets an equipment ID as a parameter and returns username at which is equipment now.
        /// </summary>
        /// <param name="ID">equipment ID</param>
        /// <returns>string if equipment exists and no errors occured, null - otherwise.</returns>
        public static string whereIsEquipment(string ID)
        {
            StringBuilder requestString = new StringBuilder(page + "hs/whos/" + ID);

            WebRequest request = WebRequest.Create(requestString.ToString());

            request.Credentials = new System.Net.NetworkCredential(login, password);

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException exception)
            {
                return null;
            }

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string type = streamReader.ReadLine();
            string name = streamReader.ReadLine();

            response.Close();
            stream.Close();
            streamReader.Close();

            return name;
        }

        /// <summary>
        /// This method checks if the equipment exists and is in storage and return Equipment in that case.
        /// </summary>
        /// <param name="ID">equipment ID</param>
        /// <returns>Equipment class if it exists, is in storage; Null in cases, when equipment does not exist or
        /// is not in storage (at a person, etc.) or error occured.</returns>
        public static Equipment doesSomeoneHasEquipment(string ID)
        {
            StringBuilder requestString = new StringBuilder(page + "hs/someones/" + ID);

            WebRequest request = WebRequest.Create(requestString.ToString());

            request.Credentials = new System.Net.NetworkCredential(login, password);

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException exception)
            {
                return null;
            }

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string type = streamReader.ReadLine();
            string name = streamReader.ReadLine();
            string equipmentType = streamReader.ReadLine();
            string serial = streamReader.ReadLine();

            response.Close();
            stream.Close();
            streamReader.Close();
            if (type != "Склад" && type != "Утеряно" && type != null)
            {
                return new Equipment(name, equipmentType, ID, serial);
            }
            return null;
        }

        /// <summary>
        /// This method gets username of a place and returns all the equipment which is at that place as an array.
        /// </summary>
        /// <param name="username">string of a place. Exactly as in 1c base.</param>
        /// <returns>Array of equipment, which the place have.</returns>
        public static Equipment[] getListOfEquipment(User user)
        {
            StringBuilder requestString = new StringBuilder(page + "hs/getList/" + user.Name);

            WebRequest request = WebRequest.Create(requestString.ToString());

            request.Credentials = new System.Net.NetworkCredential(login, password);

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (System.Net.WebException exception)
            {
                return null;
            }

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            List<Equipment> resultList = new List<Equipment>();
            while (!streamReader.EndOfStream)
            {
                string name = streamReader.ReadLine();
                string type = streamReader.ReadLine();
                string id = streamReader.ReadLine();
                string serial = streamReader.ReadLine();
                resultList.Add(new Equipment(name, type, id, serial));
            }
            response.Close();
            stream.Close();
            streamReader.Close();
            return resultList.ToArray();
        }

        public static bool getEquipment(User user, Equipment equipment)
        {
            string placeWhere = whereIsEquipment(equipment.Id);
            if (placeWhere == null || placeWhere.Equals("Утеряно"))
                return false;
            return moveEquipment(orgName, orgName, placeWhere, user.Name, equipment.Id);
        }

        public static bool returnEquipment(Equipment equipment)
        {
            string placeWhere = whereIsEquipment(equipment.Id);
            if (placeWhere.Equals("Утеряно"))
                return false;
            return moveEquipment(orgName, orgName, placeWhere, stockName, equipment.Id);
        }

        public static bool lostEquipment(Equipment equipment)
        {
            string placeWhere = whereIsEquipment(equipment.Id);
            return moveEquipment(orgName, orgName, placeWhere, "Утеряно", equipment.Id);
        }
    }
}
