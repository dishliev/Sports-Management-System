using Sports_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sports_Management_System.Clients
{
    public partial class Clients : System.Web.UI.Page
    {
        private static string sqlConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
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
                        dt.Rows.Add(contacts["clientId"],contacts["name"],
                                    contacts["surname"],contacts["age"],
                                    contacts["email"], contacts["address"], 
                                    contacts["phone"]);
                    }
                    repCustomers.DataSource = dt;
                    repCustomers.DataBind();

                }

            }
        }

        protected void client_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}
