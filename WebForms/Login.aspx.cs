using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT FullName FROM dbo.Users WHERE UserName = @u AND Password = @p", conn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@p", password);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        lblMsg.Text = "Pogrešno korisničko ime ili lozinka.";
                        return;
                    }

                    Session["UserName"] = userName;
                    Session["FullName"] = result.ToString();
                }
            }

            Response.Redirect("Shop.aspx");
        }
    }
}