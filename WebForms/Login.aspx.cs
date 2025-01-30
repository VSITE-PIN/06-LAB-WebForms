using System;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = ELITEBOOK\\SQLEXPRESS; Database = WebFormsLabos; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = true; ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid credentials!";
                }
            }
        }
    }
}