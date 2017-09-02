namespace Sports_Management_System.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Web.UI.WebControls;
    public partial class Clients : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
           DataTable dt = DBQuery.Clients();
           repCustomers.DataSource = dt;
           repCustomers.DataBind();       
        }

        protected void client_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}
