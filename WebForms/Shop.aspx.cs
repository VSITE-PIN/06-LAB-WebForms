using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // ako nije logiran -> login
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string name = txtName.Text.Trim();
            string desc = txtDesc.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(desc))
            {
                lblMsg.Text = "Naziv i opis su obavezni.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO dbo.Products(Name, Description) VALUES (@n, @d)", conn))
                {
                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@d", desc);
                    cmd.ExecuteNonQuery();
                }
            }

            txtName.Text = "";
            txtDesc.Text = "";

            LoadGrid();
            lblMsg.Text = "Spremljeno!";
        }

        private void LoadGrid()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Name, Description FROM dbo.Products ORDER BY Id", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvProducts.DataSource = dt;
                    gvProducts.DataBind();
                }
            }
        }
    }
}
