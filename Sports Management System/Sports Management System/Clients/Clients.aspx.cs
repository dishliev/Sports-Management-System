namespace Sports_Management_System.Clients
{
    using System;
    using System.Data;
    using System.Web.UI.WebControls;
    public partial class Clients : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
           DataTable dt = DBQuery.Clients();
           repCustomers.DataSource = dt;
           repCustomers.DataBind();       
        }

        protected void repCustomers_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                var id = Convert.ToInt16(e.CommandArgument.ToString());
                DBQuery.DeleteCustomer(id);
            }
        }
    }
}
