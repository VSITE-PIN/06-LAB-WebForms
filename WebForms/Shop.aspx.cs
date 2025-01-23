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
        // Uzimamo konekciju iz Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["ShopDBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid(); // Punjenje grid-a prilikom prvog učitavanja stranice}    
            }
        }
        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            // Spremanje podataka u bazu
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Proizvodi (Name, Description) VALUES (@Name, @Description)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {                     // Parametri za unos podataka
                    cmd.Parameters.AddWithValue("@Name", txtNaziv.Text);
                    cmd.Parameters.AddWithValue("@Description", txtOpis.Text);

                    con.Open();
                    cmd.ExecuteNonQuery(); // Izvršavanje SQL upita
                    con.Close();
                }
            }
            // Osvježi grid nakon spremanja
            LoadGrid();
        }
        private void LoadGrid()
        {
            // Učitavanje podataka iz baze u GridView
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Popunjavanje DataTable s podacima iz baze
                    gvProizvodi.DataSource = dt;
                    gvProizvodi.DataBind(); // Bindanje podataka na GridView
                }
            }
        }
        }
    }