using MySql.Data.MySqlClient;
using System.Data;

namespace FoodXYZ.db
{
    internal static class DbManager
    {
        private static MySqlConnection conn;

        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                string server = "localhost";
                string database = "food_xyz";
                string username = "root";
                string password = "";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }

        public static string ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }

        public static DataTable ExecuteDataQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt.Rows.Count > 0 ? dt : null;
            }
        }
    }
}
