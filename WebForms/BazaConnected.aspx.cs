using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class BazaConnected : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new
            SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}