using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebFormsLab
{
    public partial class Login : Page
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConn"].ConnectionString);

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@user AND Password=@pass", conn);
                cmd.Parameters.AddWithValue("@user", tbLoginUser.Text);
                cmd.Parameters.AddWithValue("@pass", tbLoginPass.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                    Response.Redirect("Shop.aspx");
                else
                    lblLoginMsg.Text = "Pogrešni podaci!";
            }
            catch (Exception ex) { lblLoginMsg.Text = ex.Message; }
            finally { conn.Close(); }
        }
    }
}
