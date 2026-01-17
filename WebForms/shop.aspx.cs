{
    "exclude": [
      "**/bin",
    "**/bower_components",
    "**/jspm_packages",
    "**/node_modules",
    "**/obj",
    "**/platforms"
    ]
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

public partial class Shop : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Display();
    }

    void Display()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            gvProducts.DataSource = dr;
            gvProducts.DataBind();

            dr.Close();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Products(Name,Description) VALUES(@n,@d)", con);

            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@d", txtDesc.Text);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        Display();
    }
}

}