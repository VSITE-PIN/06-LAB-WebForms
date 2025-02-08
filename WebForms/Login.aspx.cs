using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text.Trim();
            string lozinka = txtLozinka.Text;

            string ispravnoKorisnickoIme = "korisnik";
            string ispravnaLozinka = "lozinka123";

            if (korisnickoIme == ispravnoKorisnickoIme && lozinka == ispravnaLozinka)
            {
                Response.Redirect("Shop.aspx");
            }
            else
            {
                Response.Write("<script>alert('Korisničko ime ili lozinka nisu ispravni!');</script>");
            }
        }
    }
}