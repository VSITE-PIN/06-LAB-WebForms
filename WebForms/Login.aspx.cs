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
    public partial class Login : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopDBConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Prijava_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM Users Where UserName=@UserName AND Password=@Password", _connection);
            _command.Parameters.AddWithValue("@UserName", KorisnickoIme.Text);
            _command.Parameters.AddWithValue("@Password", Lozinka.Text);
            _dr = _command.ExecuteReader();
            if (_dr.HasRows)
            {
                Response.Redirect("Shop.aspx");
            }
            _connection.Close();
        }
    }
}