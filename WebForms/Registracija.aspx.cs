using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Register : Page
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConn"].ConnectionString);
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@user", conn);
                cmdCheck.Parameters.AddWithValue("@user", tbUserName.Text);
                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    lblMessage.Text = "Korisnik postoji!";
                    return;
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, FullName) VALUES (@user, @pass, @full)", conn);
                cmd.Parameters.AddWithValue("@user", tbUserName.Text);
                cmd.Parameters.AddWithValue("@pass", tbPassword.Text);
                cmd.Parameters.AddWithValue("@full", tbFullName.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex) { lblMessage.Text = ex.Message; }
            finally { conn.Close(); }
        }
    }
}
