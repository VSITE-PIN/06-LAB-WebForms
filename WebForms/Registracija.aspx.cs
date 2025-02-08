using System;
using System.Collections.Generic; 

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        private static List<string> korisnici = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistriraj_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text.Trim();
            string punoIme = txtPunoIme.Text.Trim();
            string lozinka = txtLozinka.Text;
            string ponovljenaLozinka = txtPonovljenaLozinka.Text;

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(punoIme) ||
                string.IsNullOrEmpty(lozinka) || string.IsNullOrEmpty(ponovljenaLozinka))
            {
                Response.Write("<script>alert('Sva polja su obavezna!');</script>");
                return;
            }

            if (lozinka != ponovljenaLozinka)
            {
                Response.Write("<script>alert('Lozinke se ne podudaraju!');</script>");
                return;
            }

            if (korisnici.Contains(korisnickoIme))
            {
                Response.Write("<script>alert('Korisničko ime već postoji!');</script>");
                return;
            }

            korisnici.Add(korisnickoIme);

            Response.Redirect("Login.aspx");
        }
    }
}