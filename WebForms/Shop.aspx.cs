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
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetKontroleConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;

        private void Display()
        {
            _connection.Open();

            _command = new SqlCommand("SELECT * FROM Products", _connection);
            _dr = _command.ExecuteReader();

            Elementi.DataSource = _dr;
            Elementi.DataBind();

            _dr.Close();
            _connection.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }

        protected void Spremi_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Products(Name, Description) VALUES(@name,@description)", _connection);
            _command.Parameters.AddWithValue("@name", Naziv.Text);
            _command.Parameters.AddWithValue("@description", Opis.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Display();
        }

    }
}