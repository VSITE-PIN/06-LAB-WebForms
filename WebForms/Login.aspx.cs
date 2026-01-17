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

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

            cmd.Parameters.AddWithValue("@u", txtUser.Text);
            cmd.Parameters.AddWithValue("@p", txtPass.Text);

            con.Open();
            int ok = (int)cmd.ExecuteScalar();

            if (ok == 1)
                Response.Redirect("Shop.aspx");
            else
                lblMsg.Text = "Wrong login!";
        }
    }
}

}