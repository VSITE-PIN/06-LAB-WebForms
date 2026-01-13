using System;
using System.Data;
using System.Data.SqlClient;

namespace WebFormsLab6
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserName"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            using (var conn = new SqlConnection(/* your conneection string here, or use Db.ConnectionString if accessible */))
            using (var cmd = new SqlCommand("SELECT Id, Name, Description FROM dbo.Products ORDER BY Id", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                gvProducts.DataSource = dt;
                gvProducts.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            var name = txtName.Text.Trim();
            var desc = txtDesc.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(desc))
            {
                lblMsg.Text = "Naziv i opis su obavezni.";
                return;
            }

            Db.ExecuteNonQuery(
                "INSERT INTO dbo.Products(Name, Description) VALUES(@n,@d)",
                new SqlParameter("@n", name),
                new SqlParameter("@d", desc)
            );

            txtName.Text = "";
            txtDesc.Text = "";

            LoadGrid(); 
        }
    }
}
