using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string userName = tbUserName.Text.Trim();
            string fullName = tbFullName.Text.Trim();
            string pass1 = tbPassword.Text;
            string pass2 = tbPassword2.Text;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(pass1) ||
                string.IsNullOrWhiteSpace(pass2))
            {
                lblMsg.Text = "Sva polja su obavezna.";
                return;
            }

            if (pass1 != pass2)
            {
                lblMsg.Text = "Lozinke nisu jednake.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                // provjera postoji li korisničko ime
                using (SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM dbo.Users WHERE UserName=@u", conn))
                {
                    check.Parameters.AddWithValue("@u", userName);
                    int exists = (int)check.ExecuteScalar();

                    if (exists > 0)
                    {
                        lblMsg.Text = "Korisničko ime već postoji.";
                        return;
                    }
                }

                // insert novog korisnika
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.Users(UserName, Password, FullName) VALUES (@u,@p,@f)", conn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@p", pass1);
                    cmd.Parameters.AddWithValue("@f", fullName);

                    cmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("Login.aspx");
        }
    }
}
