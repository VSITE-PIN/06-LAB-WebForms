using System;
using System.Configuration;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                lblMessage.Text = "Lozinke se ne podudaraju!";
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                SqlCommand cmdCheck = new SqlCommand(checkUserQuery, conn);
                cmdCheck.Parameters.AddWithValue("@UserName", username);
                int userExists = (int)cmdCheck.ExecuteScalar();

                if (userExists > 0)
                {
                    lblMessage.Text = "Korisničko ime već postoji!";
                }
                else
                {
                    string insertQuery = "INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, conn);
                    cmdInsert.Parameters.AddWithValue("@UserName", username);
                    cmdInsert.Parameters.AddWithValue("@Password", password);
                    cmdInsert.Parameters.AddWithValue("@FullName", fullName);
                    cmdInsert.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
