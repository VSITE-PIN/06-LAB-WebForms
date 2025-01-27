using System;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=DESKTOP-P54ISJ5\\SQLEXPRESS;Initial Catalog=WebFormsLabos;Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int userExists = (int)cmd.ExecuteScalar();

                if (userExists > 0)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    lblMessage.Text = "Neispravno korisničko ime ili lozinka!";
                }
            }
        }

    }
}

