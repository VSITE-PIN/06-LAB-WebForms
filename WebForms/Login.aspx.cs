using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@UserName AND Password=@Password", conn);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                int validUser = (int)cmd.ExecuteScalar();
                if (validUser > 0)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    lblMessage.Text = "Neispravni podaci za prijavu.";
                }
            }
        }
    }
}
