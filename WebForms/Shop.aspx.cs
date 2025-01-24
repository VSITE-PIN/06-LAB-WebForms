using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
	public partial class Shop : System.Web.UI.Page
	{


		string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				LoadProducts();
			}
		}

		private void LoadProducts()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT Id, Name, Description FROM Products";
				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				gvProducts.DataSource = dt;
				gvProducts.DataBind();
			}
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			string name = txtName.Text.Trim();
			string description = txtDescription.Text.Trim();

			if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					string query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Description", description);

					cmd.ExecuteNonQuery();
				}

				// Osvježavanje grida
				LoadProducts();

				// Resetiranje polja
				txtName.Text = "";
				txtDescription.Text = "";
			}
		}
	}




}