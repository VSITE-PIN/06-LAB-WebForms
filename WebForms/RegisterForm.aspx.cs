using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class RegisterForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kod za učitavanje stranice (ako je potrebno)
        }

        // Događaj kada korisnik klikne na dugme Registruj se
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Provera da li su uneseni svi podaci
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                // Prikazivanje poruke ako su polja prazna
                Response.Write("<script>alert('Molimo unesite sve podatke.');</script>");
                return;
            }

            // Provera da li lozinke odgovaraju
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                // Prikazivanje poruke ako lozinke nisu iste
                Response.Write("<script>alert('Lozinke se ne poklapaju.');</script>");
                return;
            }

            // Ovdje možete dodati stvarnu logiku za registraciju korisnika, kao što je unos u bazu podataka
            // Na primer: SaveUser(txtUsername.Text, txtPassword.Text);

            // Nakon što je registracija uspešna, preusmerite korisnika na Login.aspx
            Response.Redirect("Login.aspx");
        }
    }
}