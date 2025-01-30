using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Provjeri je li korisnik prijavljen (session["UserName"])
            if (Session["UserName"] == null)
            {
                // Ako nije prijavljen, preusmjeri ga na login stranicu
                Response.Redirect("~/Login.aspx");
            }

            // Ako je korisnik prijavljen, učitaj proizvode
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }


        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Description FROM Products";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        gvProducts.DataSource = dt;
                        gvProducts.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error loading products: " + ex.Message;
            }
        }

        protected void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string description = txtProductDescription.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                lblMessage.Text = "Invalid input. Please enter a valid name and description.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Products (Name, Description) VALUES (@name, @description)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.ExecuteNonQuery();
                    }
                }
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Product added successfully!";
                LoadProducts();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error adding product: " + ex.Message;
            }
        }

        protected void GvProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Provjera da je indeks valjan
            if (e.RowIndex >= 0 && e.RowIndex < gvProducts.Rows.Count)
            {
                int productId = Convert.ToInt32(gvProducts.DataKeys[e.RowIndex].Value); // Dohvati ID proizvoda

                try
                {
                    // Brisanje proizvoda iz baze
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE Id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", productId);
                            cmd.ExecuteNonQuery();  // Izvrši brisanje
                        }
                    }

                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Product deleted successfully!";
                    LoadProducts();  // Ponovno učitaj proizvode
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error deleting product: " + ex.Message;
                }
            }
            else
            {
                lblMessage.Text = "Invalid product selection.";
            }
        }



    }
}
