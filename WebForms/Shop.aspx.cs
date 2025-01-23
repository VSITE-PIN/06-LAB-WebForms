using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // Include this for DataTable

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Ensure data is only loaded once
            {
                PopulateGridView();
            }
        }

        private void PopulateGridView()
        {
            // Create a DataTable with the columns "ID", "Name", and "Description"
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            // Add rows with the data
            dt.Rows.Add(1, "Pasta", "Pasta za zube");
            dt.Rows.Add(2, "Kupka", "Kupka za kadu");
            dt.Rows.Add(3, "Kruh", "Bijeli kruh");
            dt.Rows.Add(4, "Tost", "Preprženi kruh");
            dt.Rows.Add(5, "test", "test");

            // Bind the DataTable to the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle row selection here if needed
        }
    }
}
