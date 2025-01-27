using System;
using System.Collections.Generic; // Za simulaciju baze podataka

namespace formsi
{
    public partial class Registracija : System.Web.UI.Page
    {
        // Simulirana baza korisnika
        private static List<string> korisnici = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistriraj_Click(object sender, EventArgs e)
        {
            // Dohvaćanje podataka iz forme
            string korisnickoIme = txtKorisnickoIme.Text.Trim();
            string punoIme = txtPunoIme.Text.Trim();
            string lozinka = txtLozinka.Text;
            string ponovljenaLozinka = txtPonovljenaLozinka.Text;

            // Provjera da li su sva polja popunjena
            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(punoIme) ||
                string.IsNullOrEmpty(lozinka) || string.IsNullOrEmpty(ponovljenaLozinka))
            {
                Response.Write("<script>alert('Sva polja su obavezna!');</script>");
                return;
            }

            // Provjera da li se lozinke podudaraju
            if (lozinka != ponovljenaLozinka)
            {
                Response.Write("<script>alert('Lozinke se ne podudaraju!');</script>");
                return;
            }

            // Provjera da li korisnik već postoji
            if (korisnici.Contains(korisnickoIme))
            {
                Response.Write("<script>alert('Korisničko ime već postoji!');</script>");
                return;
            }

            // Dodavanje korisnika u "bazu" (simulirano)
            korisnici.Add(korisnickoIme);

            // Preusmjeravanje na Login.aspx
            Response.Redirect("Login.aspx");
        }
    }
}