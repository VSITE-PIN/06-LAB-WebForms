using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, FullName FROM dbo.Users WHERE UserName=@u AND Password=@p", conn))
                {
                    cmd.Parameters.AddWithValue("@u", userName);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Session["UserId"] = dr.GetInt32(0);
                            Session["FullName"] = dr.GetString(1);

                            Response.Redirect("Shop.aspx");
                            return;
                        }
                    }
                }
            }

            lblMsg.Text = "Neispravno korisničko ime ili lozinka.";
        }
    }
}
