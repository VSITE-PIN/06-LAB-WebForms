using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@UserName", conn);
                checkUser.Parameters.AddWithValue("@UserName", txtUserName.Text);

                int userExists = (int)checkUser.ExecuteScalar();
                if (userExists > 0)
                {
                    lblMessage.Text = "Korisnik već postoji!";
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", conn);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.ExecuteNonQuery();

                Response.Redirect("Login.aspx");
            }
        }
    }
}
