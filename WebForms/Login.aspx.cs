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

        protected void Button1_Click(object sender, EventArgs e)
        {
			string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

			using (SqlConnection con = new SqlConnection(cs))
			{
				con.Open();

				SqlCommand cmd = new SqlCommand(
					"SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

				cmd.Parameters.AddWithValue("@u", TextBox1.Text);
				cmd.Parameters.AddWithValue("@p", TextBox2.Text);

				int broj = (int)cmd.ExecuteScalar();

				if (broj > 0)
				{
					Response.Redirect("Shop.aspx");
				}
				else
				{
					Label1.Text = "Pogrešno korisničko ime ili lozinka!";
				}
			}
		}
    }
}