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

        protected void LoadProducts()
        {
            string connStr = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvProducts.DataSource = dt;
                gvProducts.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        protected void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@Name, @Description)", conn);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text);
                cmd.ExecuteNonQuery();
                LoadProducts();
            }
        }
    }
}