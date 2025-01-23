using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
	public partial class Shop : System.Web.UI.Page
	{

		private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnection"].ToString());
		private SqlCommand _command;
		private SqlDataReader _dr;

		protected void Page_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void Display()
		{
			_connection.Open();
			_command = new SqlCommand("SELECT * FROM Products", _connection);
			_dr = _command.ExecuteReader();
			gvProducts.DataSource = _dr;
			gvProducts.DataBind();
			_dr.Close();
			_connection.Close();
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			_connection.Open();
			_command = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@Name, @Description)", _connection);
			_command.Parameters.AddWithValue("@Name", txtName.Text);
			_command.Parameters.AddWithValue("@Description", txtDescription.Text);
			_command.ExecuteNonQuery(); // ništa ne vraća
			_connection.Close();
			Display();
		}

		protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}