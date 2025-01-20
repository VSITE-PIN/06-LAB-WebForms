using System;
using System.Data.SqlClient;

namespace WebFormsLab
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;

            string connectionString = "\"Server=(LocalDb)\\MSSQLLocalDB;Database=WebFormsLabos;Trusted_Connection=True;\"";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", userName);

                con.Open();
                int userExists = (int)cmd.ExecuteScalar();

                if (userExists > 0)
                {
                    lblMessage.Text = "Korisnik već postoji!";
                }
                else
                {
                    query = "INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);

                    cmd.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}
