using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebFormsLab6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            var user = txtUserName.Text.Trim();
            var pass = txtPassword.Text;

            int ok = 0;
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM dbo.Users WHERE UserName=@u AND Password=@p", conn))
            {
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                conn.Open();
                ok = (int)cmd.ExecuteScalar();
            }

            if (ok == 1)
            {
                Session["UserName"] = user;
                Response.Redirect("Shop.aspx");
            }
            else
            {
                lblMsg.Text = "Neispravno korisničko ime ili lozinka.";
            }
        }
    }
}
