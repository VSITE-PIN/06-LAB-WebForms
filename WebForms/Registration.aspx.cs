using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebForms
{
    public partial class Registration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Provjera podudaraju li se lozinke
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                lblMessage.Text = "Lozinke se ne podudaraju!";
                return;
            }

            // Put do baze
            string connString = @"Server=localhost\SQLEXPRESS; Database=WebFormsLabos; Integrated Security=True;";

            // Spajanje na bazu (Connected arh)
            using (SqlConnection conn = new SqlConnection(connString))
            {
                
                string query = "INSERT INTO Users (UserName, Password, FullName) VALUES (@User, @Pass, @Name)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Name", txtFullName.Text);

                try
                {
                    conn.Open(); 
                    cmd.ExecuteNonQuery(); 

                    
                    Response.Redirect("Login.aspx");
                }
                catch (Exception ex)
                {
                    
                    lblMessage.Text = "Greška pri upisu u bazu: " + ex.Message;
                }
            }
        }
    }
}