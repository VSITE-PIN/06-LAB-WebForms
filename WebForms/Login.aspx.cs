using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e) { }

	protected void btnLogin_Click(object sender, EventArgs e)
	{
		string username = txtUsername.Text.Trim();
		string password = txtPassword.Text.Trim();

		string connectionString = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();

			string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@UserName", username);
				cmd.Parameters.AddWithValue("@Password", password);

				int userCount = (int)cmd.ExecuteScalar();
				if (userCount > 0)
				{
					Response.Redirect("Shop.aspx");
				}
				else
				{
					lblMessage.Text = "Invalid username or password.";
				}
			}
		}
	}
}
