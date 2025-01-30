using System;
using System.Data;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                PopulateGridView();
            }
        }

        
        private void PopulateGridView()
        {
            
            string connectionString = @"Server=ELITEBOOK\SQLEXPRESS;Database=WebFormsLabos;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                string query = "SELECT * FROM Products";

                
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

       
        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            
            string Naziv = txtNaziv.Text.Trim();
            string Opis = txtOpis.Text.Trim();

            
            if (!string.IsNullOrEmpty(Naziv) && !string.IsNullOrEmpty(Opis))
            {
                
                string connectionString = @"Server=ELITEBOOK\SQLEXPRESS;Database=WebFormsLabos;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Description)";

                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Name", Naziv);
                        cmd.Parameters.AddWithValue("@Description", Opis);

                        
                        cmd.ExecuteNonQuery();
                    }
                }

                
                txtNaziv.Text = string.Empty;
                txtOpis.Text = string.Empty;

                
                PopulateGridView();
            }
            else
            {
                
            }
        }
    }
}
