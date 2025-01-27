using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Register : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName", connection);
            checkUser.Parameters.AddWithValue("@UserName", tbUserName.Text);

            int userExists = (int)checkUser.ExecuteScalar();

            if (userExists > 0)
            {
                lblMessage.Text = "User already exists!";
            }
            else
            {
              
                SqlCommand command = new SqlCommand("INSERT INTO Users (UserName, Password, FullName) VALUES (@UserName, @Password, @FullName)", connection);
                command.Parameters.AddWithValue("@UserName", tbUserName.Text);
                command.Parameters.AddWithValue("@Password", tbPassword.Text);
                command.Parameters.AddWithValue("@FullName", tbFullName.Text);
                command.ExecuteNonQuery();

                lblMessage.Text = "Registration successful!";
                Response.Redirect("Login.aspx");
            }
        }
    }
}