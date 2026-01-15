using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Register : Page
    {
        // Use null-propagation so missing config doesn't throw during type initialization
        private readonly string cs = ConfigurationManager.ConnectionStrings["cs"]?.ConnectionString;

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

            if (string.IsNullOrEmpty(cs))
            {
                // Give a clear message instead of letting the page crash
                lblMessage.Text = "Connection string 'cs' not found. Check Web.config.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", userName);

                        object result = checkCmd.ExecuteScalar();
                        int existing = Convert.ToInt32(result); // safer conversion

                        if (existing > 0)
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
            catch (Exception ex)
            {
                // Show the error on the page while you debug. Remove or log this in production.
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}