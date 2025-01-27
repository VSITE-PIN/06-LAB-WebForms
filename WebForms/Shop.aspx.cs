using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
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
            string connectionString = "Data Source=DESKTOP-P54ISJ5\\SQLEXPRESS;Initial Catalog=WebFormsLabos;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridViewProducts.DataSource = dt;
                    GridViewProducts.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Greška pri učitavanju proizvoda: {ex.Message}');</script>");
            }
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string description = txtProductDescription.Text.Trim();

            string connectionString = "Data Source=DESKTOP-P54ISJ5\\SQLEXPRESS;Initial Catalog=WebFormsLabos;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@Name, @Description)", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('Proizvod je uspješno dodan!');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Dodavanje proizvoda nije uspjelo.');</script>");
                    }
                }

                // Osvježi grid nakon uspješnog unosa
                LoadProducts();

                // Očisti polja za unos
                txtProductName.Text = string.Empty;
                txtProductDescription.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Greška pri spremanju proizvoda: {ex.Message}');</script>");
            }
        }


    }
}


