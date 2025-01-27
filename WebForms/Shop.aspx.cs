using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Shop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadProducts(); 
        }
    }

    private void LoadProducts()
    {
        using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString()))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
            gvProducts.DataSource = command.ExecuteReader();
            gvProducts.DataBind();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString()))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@Name, @Description)", connection);
            command.Parameters.AddWithValue("@Name", tbName.Text);
            command.Parameters.AddWithValue("@Description", tbDescription.Text);
            command.ExecuteNonQuery();

            LoadProducts(); 
        }
    }
}