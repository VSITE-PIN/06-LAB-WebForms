using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Shop : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			LoadProducts();
		}
	}

	protected void btnAddProduct_Click(object sender, EventArgs e)
	{
		string name = txtProductName.Text.Trim();
		string description = txtProductDescription.Text.Trim();

		string connectionString = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();
			string insertQuery = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";
			using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
			{
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Description", description);
				cmd.ExecuteNonQuery();
			}
		}

		LoadProducts();
	}

	private void LoadProducts()
	{
		string connectionString = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString();
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();
			string query = "SELECT * FROM Products";
			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
				{
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					gvProducts.DataSource = dt;
					gvProducts.DataBind();
				}
			}
		}
	}
}
