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
        protected void btnPrijavaLogin_Click(object sender, EventArgs e)
 
        {
            string korisnickoIme = txtImeLogin.Text;
            string lozinka = txtLozinkaLogin.Text;

            string ispravnoKorisnickoIme = "korisnik";
            string ispravnaLozinka = txtLozinkaLogin.Text;

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