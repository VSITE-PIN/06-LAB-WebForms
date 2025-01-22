using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShop_Click(object sender, EventArgs e)
        {
            {
                string connStr = ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr));

            }
            string naziv = txtNaziv.Text;
            string opisNaziva = txtOpis.Text;
            string tocanNaziv = "ProductsName";
            string tocanOpis = "ProductsDescription";

            if(naziv == tocanNaziv && opisNaziva == tocanOpis)
            {
                btnShop.Visible = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}