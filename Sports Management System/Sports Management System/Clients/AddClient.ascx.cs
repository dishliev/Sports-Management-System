using Sports_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sports_Management_System.Clients
{
    public partial class AddClient : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void save_Click(object sender, EventArgs e)
        {
            ModelClient mc = new ModelClient();
            mc.Name = name.Text;
            mc.Surname = surname.Text;
            mc.Age = Convert.ToInt16(age.Text);
            mc.Email = email.Text;
            mc.Address = address.Text;
            mc.Phone = phone.Text;

            DBQuery.AddClient(mc);
        }
    }
}