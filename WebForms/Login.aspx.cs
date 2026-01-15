using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly string cs =
           ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TextBox1.Text.Trim();
            string password = TextBox2.Text;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM dbo.Users WHERE UserName = @UserName AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        // SESSION postavi
                        Session["UserName"] = userName;

                        Response.Redirect("Shop.aspx");
                        return;
                    }
                }
            }
        }
    }
    }