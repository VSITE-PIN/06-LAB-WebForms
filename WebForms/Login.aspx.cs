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
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand validateUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password", _connection);
            validateUser.Parameters.AddWithValue("@UserName", txtUserName.Text);
            validateUser.Parameters.AddWithValue("@Password", txtPassword.Text);

            int isValid = (int)validateUser.ExecuteScalar();
            if (isValid > 0)
            {
                Response.Redirect("Shop.aspx");
            }
            else
            {
                lblMessage.Text = "Neispravno korisničko ime ili lozinka!";
            }
            _connection.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}