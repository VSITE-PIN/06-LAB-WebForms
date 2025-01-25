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
    public partial class Registracija : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ToString());
        private SqlCommand _command;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registracija__Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Users(UserName, Password, FullName) VALUES(@UserName, @Password, @FullName)", _connection);
            _command.Parameters.AddWithValue("@UserName", KorisnickoIme.Text);
            _command.Parameters.AddWithValue("@FullName", PunoIme.Text);
            _command.Parameters.AddWithValue("@Password", Lozinka.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Response.Redirect("Login.aspx");
        }
    }
}