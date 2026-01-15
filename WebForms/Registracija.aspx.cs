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
        private readonly string cs =
           ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";

            string korIme = TextBox1.Text;
            string punIme = TextBox1.Text;
            string lozinka = TextBox2.Text;
            string lozinkaPotvrda = TextBox3.Text;

            if (string.IsNullOrWhiteSpace(korIme) ||
                string.IsNullOrWhiteSpace(punIme) ||
                string.IsNullOrWhiteSpace(lozinka)    ||
                 string.IsNullOrWhiteSpace(lozinkaPotvrda))
            {
                Label1.Text = "Popunite Polja.";
                return;
            }

            if (lozinka != lozinkaPotvrda)
            {
                Label1.Text = "Lozinke nisu iste";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                // Provjera postoji li korisnik
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName", conn))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", korIme);

                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        Label1.Text = "Korisničko ime već postoji.";
                        return;
                    }
                }

                using (SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO dbo.Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", conn))
                {
                    insertCmd.Parameters.AddWithValue("@UserName",korIme);
                    insertCmd.Parameters.AddWithValue("@Password", lozinka);
                    insertCmd.Parameters.AddWithValue("@FullName", punIme);

                    insertCmd.ExecuteNonQuery();
                }
            }

            Response.Redirect("Login.aspx");
        }


        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}