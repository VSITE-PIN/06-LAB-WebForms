using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Shop : Page
    {
        string connString = @"Server=localhost\SQLEXPRESS; Database=WebFormsLabos; Integrated Security=True;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrikaziProizvode();
            }
        }

        private void PrikaziProizvode()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Name, Description FROM Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(); // Connected arh
                    gvProducts.DataSource = reader;
                    gvProducts.DataBind();
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Greška pri prikazu: " + ex.Message;
                }
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Products (Name, Description) VALUES (@Name, @Desc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Desc", txtProductDescription.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "Proizvod uspješno dodan!";
                    txtProductName.Text = "";
                    txtProductDescription.Text = "";
                    PrikaziProizvode(); 
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Greška pri spremanju: " + ex.Message;
                }
            }
        }
    }
}