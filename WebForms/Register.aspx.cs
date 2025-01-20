using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e) { }

	protected void btnRegister_Click(object sender, EventArgs e)
	{
		string username = txtUsername.Text.Trim();
		string password = txtPassword.Text.Trim();
		string fullName = txtFullName.Text.Trim();

		if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName))
		{
			lblMessage.Text = "All fields are required.";
			return;
		}

		string connectionString = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();

			string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
			using (SqlCommand cmd = new SqlCommand(checkUserQuery, connection))
			{
				cmd.Parameters.AddWithValue("@UserName", username);
				int userCount = (int)cmd.ExecuteScalar();
				if (userCount > 0)
				{
					lblMessage.Text = "Username already exists.";
					return;
				}
			}

			string insertQuery = "INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)";
			using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
			{
				cmd.Parameters.AddWithValue("@UserName", username);
				cmd.Parameters.AddWithValue("@Password", password);
				cmd.Parameters.AddWithValue("@FullName", fullName);
				cmd.ExecuteNonQuery();
			}
		}

		lblMessage.ForeColor = System.Drawing.Color.Green;
		lblMessage.Text = "Registration successful!";
		Response.Redirect("Login.aspx");
	}
}
