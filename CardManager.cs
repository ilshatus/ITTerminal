using System.Data.SqlClient;
using System.Configuration;

namespace ITTerminal
{
    class CardManager
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private static string sqlExpression = "SELECT TOP 1 [surname_ru],[name_ru],[sname_ru],[position],[status] FROM [team1_test_skip_card].[dbo].[data] WHERE [Card ID] = @card_id";
        
        //Возвращает объект User с полученными данными либо null.
        //Возвращает null, если владелец карты не найден или если владелец карты не является действующим сотрудником или студентом.
        public static User getUser(string card_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
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
    }
}
