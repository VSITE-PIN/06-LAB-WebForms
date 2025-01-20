using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace YourNamespace
{
    public partial class Shop : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ShopDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                Response.Write("<script>alert('Sva polja su obavezna!');</script>");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            // Osvježavanje grida nakon unosa
            BindGrid();

            // Brisanje unesenih podataka iz textboxova
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void BindGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridViewProducts.DataSource = dt;
                GridViewProducts.DataBind();
            }
        }
    }
}
