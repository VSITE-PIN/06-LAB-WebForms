using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebFormsLab
{
    public partial class Shop : Page
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsConn"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGrid();
        }

        private void LoadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvProducts.DataSource = dt;
            gvProducts.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@name, @desc)", conn);
                cmd.Parameters.AddWithValue("@name", tbProductName.Text);
                cmd.Parameters.AddWithValue("@desc", tbDescription.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { /* handle error */ }
            finally { conn.Close(); }
            LoadGrid();
            tbProductName.Text = ""; tbDescription.Text = "";
        }
    }
}
