using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Registracija : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Registriraj_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}