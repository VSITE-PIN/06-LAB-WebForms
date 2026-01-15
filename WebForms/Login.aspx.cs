using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Molim unesi korisničko ime i lozinku.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        // SESSION postavi
                        Session["UserName"] = userName;

                        Response.Redirect("Shop.aspx");
                        return;
                    }
                }
            }

            lblMessage.Text = "Pogrešno korisničko ime ili lozinka.";
        }
    }
}