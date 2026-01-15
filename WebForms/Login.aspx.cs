using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Login : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = @"Server=localhost\SQLEXPRESS; Database=WebFormsLabos; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Traži korisnika s tim podacima
                string query = "SELECT COUNT(*) FROM Users WHERE UserName=@User AND Password=@Pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);

                try
                {
                    conn.Open();
                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        // Ako postoji, ide u Shop
                        Response.Redirect("Shop.aspx");
                    }
                    else
                    {
                        lblMessage.Text = "Krivi podaci za prijavu!";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Greška: " + ex.Message;
                }
            }
        }
    }
}