namespace Sports_Management_System
{
    using Sports_Management_System.Models;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    public class DBQuery
    {
        private static string sqlConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static DataTable Clients()
        {
            using (SqlConnection con = new SqlConnection(sqlConn))
            {
                string query = "select * from clients";
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
                    Dictionary<string, string> column;
                    DataTable dt = new DataTable();

                    while (reader.Read())
                    {
                        column = new Dictionary<string, string>();

                        column["clientId"] = reader["clientId"].ToString();
                        column["name"] = reader["name"].ToString();
                        column["surname"] = reader["surname"].ToString();
                        column["age"] = reader["age"].ToString();
                        column["email"] = reader["email"].ToString();
                        column["address"] = reader["address"].ToString();
                        column["phone"] = reader["phone"].ToString();

                        rows.Add(column);
                    }

                    con.Close();

                    dt.Columns.Add("clientId");
                    dt.Columns.Add("name");
                    dt.Columns.Add("surname");
                    dt.Columns.Add("age");
                    dt.Columns.Add("email");
                    dt.Columns.Add("address");
                    dt.Columns.Add("phone");

                    foreach (Dictionary<string, string> contacts in rows)
                    {
                        dt.Rows.Add(contacts["clientId"], contacts["name"],
                                    contacts["surname"], contacts["age"],
                                    contacts["email"], contacts["address"],
                                    contacts["phone"]);
                    }
                    return dt;
                }

            }
        }
        public static void DeleteCustomer(int id)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM clients WHERE clientId =@clientId";
                cmd.Parameters.AddWithValue("@clientId", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                con.Close();

            }
        }
        public static void AddClient(ModelClient mc)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into clients (name, surname, age, email, address, phone) values(@name, @surname, @age, @email, @address, @phone)";
                cmd.Parameters.AddWithValue("@name", mc.Name);
                cmd.Parameters.AddWithValue("@surname", mc.Surname);
                cmd.Parameters.AddWithValue("@age", mc.Age);
                cmd.Parameters.AddWithValue("@email", mc.Email);
                cmd.Parameters.AddWithValue("@address", mc.Address);
                cmd.Parameters.AddWithValue("@phone", mc.Phone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}