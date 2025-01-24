using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            {
                Display(); 
            }
        }

        private void Display()
        {
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM Products", _connection);
            _dr = _command.ExecuteReader();

            gvProducts.DataSource = _dr;
            gvProducts.DataBind();

            _dr.Close();
            _connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Products (Name, Description) VALUES (@name, @description)", _connection);
            _command.Parameters.AddWithValue("@name", Naziv.Text);
            _command.Parameters.AddWithValue("@description", Opis.Text);
            _command.ExecuteNonQuery();
            _connection.Close();

            Display(); 
            
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Display(); 
        }
    }
}
