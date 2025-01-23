using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
	public partial class Login : System.Web.UI.Page
	{
		private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnection"].ToString());
		private SqlCommand _command;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			_command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password", _connection);
			_command.Parameters.AddWithValue("@UserName", txtUserName.Text);
			_command.Parameters.AddWithValue("@Password", txtPassword.Text);
			_connection.Open();
			int valid = (int)_command.ExecuteScalar();
			_connection.Close();
			if (valid > 0)
			{
				Response.Redirect("Shop.aspx");
			}
			else
			{
				lblMessage.Text = "Neispravni podaci!";
			}
		}
	}
}