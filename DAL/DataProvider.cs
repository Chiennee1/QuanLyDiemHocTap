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
                    //Tìm tất cả parameter names bằng Regex
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"@\w+");
                    System.Text.RegularExpressions.MatchCollection matches = regex.Matches(query);
                    // Tạo HashSet để tránh thêm parameter trùng lặp
                    System.Collections.Generic.HashSet<string> addedParams = new System.Collections.Generic.HashSet<string>();
                    int i = 0;
                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string paramName = match.Value;

                        if (!addedParams.Contains(paramName))
                        {
                            cmd.Parameters.AddWithValue(paramName, parameters[i]);
                            addedParams.Add(paramName);
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
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"@\w+");
                    System.Text.RegularExpressions.MatchCollection matches = regex.Matches(query);
                    // Tạo HashSet để tránh thêm parameter trùng lặp
                    System.Collections.Generic.HashSet<string> addedParams = new System.Collections.Generic.HashSet<string>();
                    int i = 0;
                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string paramName = match.Value;

                        if (!addedParams.Contains(paramName))
                        {
                            cmd.Parameters.AddWithValue(paramName, parameters[i]);
                            addedParams.Add(paramName);
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
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"@\w+");
                    System.Text.RegularExpressions.MatchCollection matches = regex.Matches(query);
                    // Tạo HashSet để tránh thêm parameter trùng lặp
                    System.Collections.Generic.HashSet<string> addedParams = new System.Collections.Generic.HashSet<string>();
                    int i = 0;

                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string paramName = match.Value;

                        if (!addedParams.Contains(paramName))
                        {
                            cmd.Parameters.AddWithValue(paramName, parameters[i]);
                            addedParams.Add(paramName);
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