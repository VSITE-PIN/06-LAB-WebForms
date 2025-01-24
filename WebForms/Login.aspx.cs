using System;
using System.Data.SqlClient;
using System.Web;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnectionString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password); 

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        Session["UserName"] = username;
                        Response.Redirect("Home.aspx"); 
                    }
                    else
                    {
                        LoginMessage.Text = "Pogrešno korisničko ime ili lozinka.";
                    }
                }
                catch (Exception ex)
                {
                    LoginMessage.Text = "Greška pri prijavi: " + ex.Message;
                }
            }
        }
    }
}
