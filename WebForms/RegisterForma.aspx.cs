using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class RegisterForma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string fullName = TextBox2.Text;
            string password = TextBox3.Text;
            string confirmPassword = TextBox4.Text;

            if (password != confirmPassword)
            {

                return;
            }
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnectionString"].ConnectionString;
            string insertQuery = "INSERT INTO dbo.Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                // Dodavanje parametara kako bi se izbjegle SQL injekcije

                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = username;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;
                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 50).Value = fullName;

                try
                {
                    // Otvori konekciju i izvrši upit
                    connection.Open();
                    command.ExecuteNonQuery();

                    Response.Redirect("Login.aspx");

                        
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Neuspjesno");
                }

            }
        }
    }
}