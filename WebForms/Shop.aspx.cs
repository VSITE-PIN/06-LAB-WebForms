using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProizvodi();
            }
        }

        protected void ButtonSpremi_Click(object sender, EventArgs e)
        {
           

            // Veza s bazom podataka
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnectionString"].ConnectionString;
            string insertQuery = "INSERT INTO dbo.Products (Naziv, Opis) VALUES (@Naziv, @Opis)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); 

                    LoadProizvodi();
                    ClearFields(); 

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Došlo je do greške: " + ex.Message + "');</script>");
                }
            }
        }

        private void LoadProizvodi()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConnectionString"].ConnectionString;
            string selectQuery = "SELECT Naziv, Opis FROM dbo.Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataAdapter.Fill(dataTable);

            }
        }

        private void ClearFields()
        {
           
        }
    }
}