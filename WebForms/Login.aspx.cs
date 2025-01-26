using System;
using System.Data.SqlClient;
using System.Configuration;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());
        private SqlCommand _command;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                _connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @username AND Password = @password";
                _command = new SqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@username", username);
                _command.Parameters.AddWithValue("@password", password);

                int count = (int)_command.ExecuteScalar();

                if (count > 0)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    lblMessage.Text = "Neispravno korisničko ime ili lozinka.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Greška: " + ex.Message;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
