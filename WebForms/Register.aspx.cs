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
    public partial class Register : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName", _connection);
            checkUser.Parameters.AddWithValue("@UserName", txtUserName.Text);
            int exists = (int)checkUser.ExecuteScalar();

            if (exists > 0)
            {
                lblMessage.Text = "Korisničko ime već postoji!";
            }
            else
            {
                SqlCommand insertUser = new SqlCommand("INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", _connection);
                insertUser.Parameters.AddWithValue("@UserName", txtUserName.Text);
                insertUser.Parameters.AddWithValue("@Password", txtPassword.Text);
                insertUser.Parameters.AddWithValue("@FullName", txtFullName.Text);
                insertUser.ExecuteNonQuery();

                Response.Redirect("Login.aspx");
            }
            _connection.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}