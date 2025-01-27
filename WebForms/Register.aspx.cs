using System;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fullname = txtFullName.Text.Trim();

            string connectionString = "Data Source=DESKTOP-P54ISJ5\\SQLEXPRESS;Initial Catalog=WebFormsLabos;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, FullName) VALUES (@Username, @Password, @FullName)", con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullname);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "Korisnik uspješno registriran!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "Došlo je do greške prilikom registracije.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Greška: {ex.Message}";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }


    }
}


