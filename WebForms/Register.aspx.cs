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
	public partial class Register : System.Web.UI.Page
	{

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text.Trim();
			string fullName = txtFullName.Text.Trim();
			string password = txtPassword.Text.Trim();
			string confirmPassword = txtConfirmPassword.Text.Trim();

			if (password != confirmPassword)
			{
				lblMessage.Text = "Lozinke se ne podudaraju!";
				return;
			}

			// Provjera postoji li korisnik
			string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
				SqlCommand cmd = new SqlCommand(checkUserQuery, conn);
				cmd.Parameters.AddWithValue("@UserName", userName);

				int userExists = (int)cmd.ExecuteScalar();

				if (userExists > 0)
				{
					lblMessage.Text = "Korisničko ime već postoji!";
					return;
				}

				// Unos novog korisnika
				string insertQuery = "INSERT INTO Users (UserName, FullName, Password) VALUES (@UserName, @FullName, @Password)";
				cmd = new SqlCommand(insertQuery, conn);
				cmd.Parameters.AddWithValue("@UserName", userName);
				cmd.Parameters.AddWithValue("@FullName", fullName);
				cmd.Parameters.AddWithValue("@Password", password);

				cmd.ExecuteNonQuery();
			}

			// Preusmjeravanje na Login stranicu
			Response.Redirect("Login.aspx");
		}
		protected void Page_Load(object sender, EventArgs e)
		{

		}
	}
}