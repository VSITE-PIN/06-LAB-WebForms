using System;
using System.Data.SqlClient;

public static class Db
{
    private static string ConnectionString =>
        System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

    public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(ConnectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteScalar();
        }
    }

    public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
    {
        using (var conn = new SqlConnection(ConnectionString))
        using (var cmd = new SqlCommand(sql, conn))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}

namespace WebFormsLab6
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            var user = txtUserName.Text.Trim();
            var full = txtFullName.Text.Trim();
            var pass1 = txtPassword.Text;
            var pass2 = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(full) || string.IsNullOrWhiteSpace(pass1))
            {
                lblMsg.Text = "Sva polja su obavezna.";
                return;
            }

            if (pass1 != pass2)
            {
                lblMsg.Text = "Lozinke se ne podudaraju.";
                return;
            }

            
            var exists = (int)Db.ExecuteScalar(
                "SELECT COUNT(1) FROM dbo.Users WHERE UserName = @u",
                new SqlParameter("@u", user)
            );

            if (exists > 0)
            {
                lblMsg.Text = "Korisničko ime već postoji.";
                return;
            }

            Db.ExecuteNonQuery(
                "INSERT INTO dbo.Users(UserName, Password, FullName) VALUES(@u,@p,@f)",
                new SqlParameter("@u", user),
                new SqlParameter("@p", pass1),
                new SqlParameter("@f", full)
            );

            
            Response.Redirect("Login.aspx");
        }
    }
}
