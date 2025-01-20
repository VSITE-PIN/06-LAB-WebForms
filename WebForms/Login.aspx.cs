using System;

namespace YourNamespace
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            // 1. Dohvati unesene podatke
            string korisnickoIme = txtKorisnickoIme.Text.Trim();
            string lozinka = txtLozinka.Text;

            // 2. Simuliraj provjeru podataka (hardkodirani podaci za primjer)
            string ispravnoKorisnickoIme = "korisnik";
            string ispravnaLozinka = "lozinka123";

            if (korisnickoIme == ispravnoKorisnickoIme && lozinka == ispravnaLozinka)
            {
                // 3. Ako su podaci točni, preusmjeri korisnika na Shop.aspx
                Response.Redirect("Shop.aspx");
            }
            else
            {
                // 4. Ako su podaci netočni, prikaži poruku o grešci
                Response.Write("<script>alert('Korisničko ime ili lozinka nisu ispravni!');</script>");
            }
        }
    }
}
