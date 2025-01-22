using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            string korisnickoime = txtImeReg.Text;
            string punoime = "korisnik";
            string lozinka = txtLozinkaReg.Text;
            string ponovljenalozinka = txtPonReg.Text;

            if (korisnickoime == punoime && lozinka == ponovljenalozinka)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Korisničko ime ili lozinka nisu ispravni!');</script>");
            }

        }

    
    }
}