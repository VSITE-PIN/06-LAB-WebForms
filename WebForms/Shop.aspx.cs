using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebForms.Data;
using WebForms.Models;

namespace WebForms
{
    public partial class Shop : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] == null)
                {
                    lblMessage.Text = "Niste prijavljeni. Molimo prijavite se.";
                    btnSave.Enabled = false;
                    txtName.Enabled = false;
                    txtDescription.Enabled = false;
                    gvProducts.Visible = false;
                    return;
                }

                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            using (var db = new AppDbContext())
            {
                gvProducts.DataSource = db.Products.ToList();
                gvProducts.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                lblMessage.Text = "Unesi naziv i opis proizvoda.";
                return;
            }

            using (var db = new AppDbContext())
            {
                var product = new Product
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };

                db.Products.Add(product);
                db.SaveChanges();
            }

            txtName.Text = "";
            txtDescription.Text = "";

            LoadProducts();
        }
    }
}