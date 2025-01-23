using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
	public partial class Registration : System.Web.UI.Page
	{
		private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnection"].ToString());

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			if (password1.Text != password2.Text)
			{
				lblMessage.Text = "Lozinke nisu jednake!";
				return;
			}

			// Provjeri postoji li korisnik
			SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName", _connection);
			cmdCheck.Parameters.AddWithValue("@UserName", txtUserName.Text);
			_connection.Open();
			int exists = (int)cmdCheck.ExecuteScalar();

			if (exists > 0)
			{
				_connection.Close();
				lblMessage.Text = "Korisničko ime već postoji!";
				return;
			}

			// Dodaj novog korisnika
			SqlCommand cmdInsert = new SqlCommand("INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", _connection);
			cmdInsert.Parameters.AddWithValue("@UserName", txtUserName.Text);
			cmdInsert.Parameters.AddWithValue("@Password", password1.Text);
			cmdInsert.Parameters.AddWithValue("@FullName", txtFullName.Text);
			cmdInsert.ExecuteNonQuery();
			_connection.Close();
			Response.Redirect("Login.aspx");			
		}
	}
}