using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static string connectionString = @"Data Source=DESKTOP-94OG1PU\SQLEXPRESS;Initial Catalog=QuanLyDiemTHCS;Integrated Security=True";

        public static void SetConnectionString(string connStr)
        {
            connectionString = connStr;
        }

        public static DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        public static object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                result = cmd.ExecuteScalar();
            }
            return result;
        }
    }
}
