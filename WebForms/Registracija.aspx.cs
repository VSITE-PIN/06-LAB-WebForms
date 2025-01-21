using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConnectionString"].ConnectionString);
        private SqlCommand _command;
        private SqlDataReader _dr;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();


            try
            {
                // Otvaramo konekciju
                _connection.Open();

                // Provera da li korisničko ime već postoji
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, _connection))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", username);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        lblMessage.Text = "Korisničko ime već postoji!";
                        return;
                    }
                }

                // Ubacivanje korisnika u bazu
                string insertQuery = "INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, _connection))
                {
                    insertCmd.Parameters.AddWithValue("@UserName", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@FullName", fullName);
                    insertCmd.ExecuteNonQuery();
                }

                // Uspešna registracija - redirekcija na Login stranicu
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Došlo je do greške: " + ex.Message;
            }
            finally
            {
                // Zatvaramo konekciju
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
    }
}