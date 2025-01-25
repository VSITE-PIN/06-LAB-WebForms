using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayProducts();
            }
        }

        private void DisplayProducts()
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvProducts.DataSource = dt;
            gvProducts.DataBind();
            _connection.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@Name, @Description)", _connection);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.ExecuteNonQuery();
            _connection.Close();

            DisplayProducts();
        }
        
    }
}