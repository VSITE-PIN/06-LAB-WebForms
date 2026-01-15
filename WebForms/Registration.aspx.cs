using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebForms.Data;
using WebForms.Models;

namespace WebForms
{
    public partial class Registration : Page
    {

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string userName = txtUserName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string pass1 = txtPassword.Text;
            string pass2 = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(pass1) ||
                string.IsNullOrWhiteSpace(pass2))
            {
                lblMessage.Text = "Molim popuni sva polja.";
                return;
            }

            if (pass1 != pass2)
            {
                lblMessage.Text = "Lozinke se ne podudaraju.";
                return;
            }

            using (var db = new AppDbContext())
            {
                if (db.Users.Any(u => u.UserName == userName))
                {
                    lblMessage.Text = "Korisničko ime već postoji.";
                    return;
                }

                var user = new User
                {
                    UserName = userName,
                    FullName = fullName,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(pass1)
                };

                db.Users.Add(user);
                db.SaveChanges();
            }

            Response.Redirect("Login.aspx");
        }
    }
}