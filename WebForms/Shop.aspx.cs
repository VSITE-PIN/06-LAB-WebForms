using System;
using System.Data;
using System.Data.SqlClient;

namespace WebFormsLab
{
    public partial class Shop : System.Web.UI.Page
    {
        private string connectionString ="Server=(LocalDb)\MSSQLLocalDB;Database=WebFormsLabos;Trusted_Connection=True;";    

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridProducts.DataSource = dt;
                gridProducts.DataBind();
            }
        }
    }
}
