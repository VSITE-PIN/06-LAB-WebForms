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
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text.Trim();
			string password = txtPassword.Text.Trim();

			// Provjera korisnika u bazi podataka
			string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@UserName", userName);
				cmd.Parameters.AddWithValue("@Password", password);

				int userExists = (int)cmd.ExecuteScalar();

				if (userExists > 0)
				{
					// Uspješna prijava
					Response.Redirect("Shop.aspx");
				}
				else
				{
					lblMessage.Text = "Pogrešno korisničko ime ili lozinka.";
				}
			}
		}
	}
}