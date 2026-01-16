using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // zaštita stranice
            if (Session["UserId"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            lblWelcome.Text = "Dobrodošli, " + Session["FullName"];

            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Name, Description FROM dbo.Products", conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        gvProducts.DataSource = dr;
                        gvProducts.DataBind();
                    }
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string name = tbName.Text.Trim();
            string description = tbDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                lblMsg.Text = "Naziv i opis su obavezni.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.Products(Name, Description) VALUES (@n,@d)", conn))
                {
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.ExecuteNonQuery();
                }
            }

            tbName.Text = "";
            tbDescription.Text = "";

            LoadProducts();
        }
    }
}
