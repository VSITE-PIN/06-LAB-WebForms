using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Registration : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string userName = txtUserName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string pass1 = txtPassword.Text;
            string pass2 = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(pass1) ||
                string.IsNullOrWhiteSpace(pass2))
            {
                lblMessage.Text = "Molim popuni sva polja.";
                return;
            }

            if (pass1 != pass2)
            {
                lblMessage.Text = "Lozinke se ne podudaraju.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                // Provjera postoji li korisnik
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName", conn))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", userName);

                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        lblMessage.Text = "Korisničko ime već postoji.";
                        return;
                    }
                }

                using (SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO dbo.Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", conn))
                {
                    insertCmd.Parameters.AddWithValue("@UserName", userName);
                    insertCmd.Parameters.AddWithValue("@Password", pass1);
                    insertCmd.Parameters.AddWithValue("@FullName", fullName);

                    insertCmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("Login.aspx");
        }
    }
}
