using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string userName = txtUserName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string pass1 = txtPassword.Text;
            string pass2 = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(pass1))
            {
                lblMsg.Text = "Sva polja su obavezna.";
                return;
            }

            if (pass1 != pass2)
            {
                lblMsg.Text = "Lozinke se ne podudaraju.";
                return;
            }

            using (var conn = new SqlConnection(cs))
            {
                conn.Open();

                using (var checkCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Users WHERE UserName = @u", conn))
                {
                    checkCmd.Parameters.AddWithValue("@u", userName);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        lblMsg.Text = "Korisničko ime je već zauzeto.";
                        return;
                    }
                }

                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.Users(UserName, Password, FullName) VALUES (@u, @p, @f)", conn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@p", pass1);
                    cmd.Parameters.AddWithValue("@f", fullName);
                    cmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("Login.aspx");
        }

        protected void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}