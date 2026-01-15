using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebForms.Data;
using WebForms.Models;

namespace WebForms
{
    public partial class Login : Page
    {

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Unesi korisničko ime i lozinku.";
                return;
            }

            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == userName);

                if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    lblMessage.Text = "Pogrešno korisničko ime ili lozinka.";
                    return;
                }

                Session["UserName"] = user.UserName;
                Response.Redirect("Shop.aspx");
            }
        }
    }
}