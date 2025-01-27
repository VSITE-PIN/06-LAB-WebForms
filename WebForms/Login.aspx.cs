using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString()))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password", connection);
            command.Parameters.AddWithValue("@UserName", tbUserName.Text);
            command.Parameters.AddWithValue("@Password", tbPassword.Text);

            int userExists = (int)command.ExecuteScalar();

            if (userExists > 0)
            {
                Response.Redirect("Shop.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password!";
            }
        }
    }
}