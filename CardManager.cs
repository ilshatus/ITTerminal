using System.Data.SqlClient;
using System.Configuration;
using System;

namespace ITTerminal
{
    class CardManager
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private static string sqlExpression1 = "SELECT TOP 1 [surname_ru],[name_ru],[sname_ru],[position],[status],[Card ID] FROM [team1_test_skip_card].[dbo].[data] WHERE [Card ID] = @card_id";
        private static string sqlExpression2 = "SELECT TOP 1 [surname_ru],[name_ru],[sname_ru],[position],[status],[Card ID] FROM [team1_test_skip_card].[dbo].[data] WHERE [surname_ru] = @surname AND [name_ru] = @name";
        private static string sqlExpression3 = "SELECT TOP 1 [surname_ru],[name_ru],[sname_ru],[position],[status],[Card ID] FROM [team1_test_skip_card].[dbo].[data] WHERE [surname_ru] = @surname AND [name_ru] = @name AND [sname_ru] = @sname";


        //Returns User or null.
        //Returns null, if card owner isn't found or if card owner isn't worker or student now.
        public static User getUser(string card_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                SqlParameter nameParam = new SqlParameter("@card_id", card_id);
                command.Parameters.Add(nameParam);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string surname_ru = reader.GetString(0);
                    string name_ru = reader.GetString(1);
                    object sname_ru = reader.GetValue(2);
                    string position = reader.GetString(3);
                    string status = reader.GetString(4);

                    if (status.Equals("Действует") && (position.Contains("Сотрудник") || position.Contains("Студент")))
                    {
                        if (sname_ru != null && !sname_ru.Equals(""))
                            return new User(surname_ru + " " + name_ru + " " + sname_ru, card_id);
                        else return new User(surname_ru + " " + name_ru, card_id);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return null;
        }

        //Returns User or null.
        //Returns null, if card owner isn't found or if card owner isn't worker or student now.
        public static User getUser(string surname, string name, string sname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command;
                if (sname.Equals(""))
                    command = new SqlCommand(sqlExpression2, connection);
                else
                    command = new SqlCommand(sqlExpression3, connection);

                SqlParameter param = new SqlParameter("@surname", surname);
                command.Parameters.Add(param);
                param = new SqlParameter("@name", name);
                command.Parameters.Add(param);
                param = new SqlParameter("@sname", sname);
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    string surname_ru = reader.GetString(0);
                    string name_ru = reader.GetString(1);
                    object sname_ru = reader.GetValue(2);
                    string position = reader.GetString(3);
                    string status = reader.GetString(4);
                    string card_id = reader.GetString(5);

                    if (status.Equals("Действует") && (position.Contains("Сотрудник") || position.Contains("Студент")))
                    {
                        if (position.Contains("Сотрудник")) position = "Сотрудник";
                        if (position.Contains("Студент")) position = "Студент";
                        if (sname_ru != null && !sname_ru.Equals(""))
                            return new User(surname_ru + " " + name_ru + " " + sname_ru, card_id, position);
                        else return new User(surname_ru + " " + name_ru, card_id, position);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return null;
        }
    }
}
