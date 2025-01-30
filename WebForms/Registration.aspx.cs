using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Provjera da su sva polja popunjena
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                lblMessage.Text = "Sva polja su obavezna.";
                return;
            }

            // Provjera da su lozinke iste
            if (password != confirmPassword)
            {
                lblMessage.Text = "Lozinke se ne podudaraju.";
                return;
            }

            // Konekcija na bazu
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Provjera da li korisničko ime već postoji u bazi
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(checkUserQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            lblMessage.Text = "Korisničko ime već postoji.";
                            return;
                        }
                    }

                    // Ako korisnik ne postoji, dodaj ga u bazu
                    string insertQuery = "INSERT INTO Users (UserName, FullName, Password) VALUES (@UserName, @FullName, @Password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Password", password); // Lozinka pohranjena nešifrirana

                        cmd.ExecuteNonQuery(); // Unos u bazu
                    }

                    // Ako je registracija uspješna, preusmjeri korisnika na Login
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Registracija uspješna! Preusmjeravam vas na login.";

                    // Postavljanje sesije i preusmjeravanje
                    Session["UserName"] = username;
                    Response.Redirect("Login.aspx"); // Preusmjeravanje na login nakon registracije
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}