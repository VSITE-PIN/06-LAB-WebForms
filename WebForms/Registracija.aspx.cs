using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());
        private SqlCommand _command;

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand("INSERT INTO Users (Username, Password, FullName) VALUES (@username, @password, @fullname)", _connection);
                _command.Parameters.AddWithValue("@username", tbKi.Text.Trim());
                _command.Parameters.AddWithValue("@password", tbLozinka.Text.Trim());
                _command.Parameters.AddWithValue("@fullname", tbIme.Text.Trim());
                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    lblMessage.Text = "Registracija uspješna! Preusmeravanje na prijavu...";

                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblMessage.Text = "Greška pri registraciji. Pokušajte ponovo.";
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand("DELETE FROM Users WHERE Username = @username", _connection);
                _command.Parameters.AddWithValue("@username", tbKi.Text.Trim());
                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    lblMessage.Text = "Korisnik je uspješno obrisan.";
                }
                else
                {
                    lblMessage.Text = "Korisnik nije pronađen.";
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
