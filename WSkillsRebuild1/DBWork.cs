using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySqlConnector;
using System.Globalization;

namespace WSkillsRebuild1
{
    static class DBWork
    {
        public static MySqlConnection TheConnection { get; set; } = CreateConnection();
        public static MySqlConnection CreateConnection() => new MySqlConnection("database=experimental;server=localhost;username=root;password=password");
        /// <summary>
        /// Execuiting your SQL query and returns needed data
        /// </summary>
        /// <param name="command"></param>
        /// <param name="connection"></param>
        /// <remarks>Keep in mind that if you're using your own connection - you have to open it first</remarks>
        /// <returns></returns>
        public static DataTable GetData(string command, MySqlConnection connection)
        {
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataAdapter DA = new MySqlDataAdapter(command, connection);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }
        /// <summary>
        /// Execuiting your SQL query and returns needed data
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable GetData(string command)
        {
            var connection = TheConnection;
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataAdapter DA = new MySqlDataAdapter(command, connection);
            DataTable DT = new DataTable();
            connection.Open();
            DA.Fill(DT);
            connection.Close();
            return DT;
        }
        /// <summary>
        /// Checks user's login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <param name="position"></param>
        /// <param name="connection"></param>
        /// <remarks>Keep in mind that if you're using your own connection - you have to open it first</remarks>
        /// <returns></returns>
        public static bool CheckLogin(string login, string pass, string position, MySqlConnection connection)
        {
            var creds = GetData($"SELECT {position}Login, {position}Pass FROM r{position} WHERE {position}Login = \"{login}\"", connection);
            foreach (DataRow item in creds.Rows)
            {
                if (item.ItemArray[0].ToString() == login && item.ItemArray[1].ToString() == pass)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks user's login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static bool CheckLogin(string login, string pass, string position)
        {
            var creds = GetData($"SELECT {position}Login, {position}Pass FROM r{position} WHERE {position}Login = \"{login}\"", TheConnection);
            foreach (DataRow item in creds.Rows)
            {
                if (item.ItemArray[0].ToString() == login && item.ItemArray[1].ToString() == pass)
                {
                    return true;
                }
            }
            return false;
        }
        public static void SendOrder(int ID,string patientLogin,string[] services,DateTime date)
        {
            List<int> serviceCodes = new List<int>();
            foreach (var item in services)
            {
                serviceCodes.Add((int)GetData($"SELECT serviceCode FROM experimental.cservice WHERE serviceTitle = \"{item}\"").Rows[0].ItemArray[0]);
            }
            var cmd = TheConnection.CreateCommand();
            cmd.CommandText = "INSERT INTO experimental.rorder(orderId,orderDate,orderPatientLogin) VALUES \n" +
                $"({ID},\"{date.ToString("yyyy-MM-dd")}\",\"{patientLogin}\");\n";
            cmd.CommandText += " INSERT INTO experimental.jorder_service VALUES \n";
            foreach (var code in serviceCodes)
            {
                cmd.CommandText += $"(\n{code},{ID}),";
            }
            cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1,1);
            cmd.CommandText += ";";
            TheConnection.Open();
            cmd.ExecuteNonQuery();
            TheConnection.Close();
        }
    }
}
