using System;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = ELITEBOOK\\SQLEXPRESS; Database = WebFormsLabos; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = true; ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn);
                checkUserCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                int count = (int)checkUserCmd.ExecuteScalar();

                if (count > 0)
                {
                    lblMessage.Text = "Username already exists!";
                }
                else
                {
                    
                    string insertQuery = "INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    insertCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    insertCmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    insertCmd.ExecuteNonQuery();

                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}