using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WebFormsLabosConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _reader;


        private void Display()
        {
            //otvaramo konekciju
            _connection.Open();
            //konekciji dodjeljujemo naredbu
            _command = new SqlCommand("SELECT * FROM Products", _connection);
            //izvršavamo naredbu
            _reader = _command.ExecuteReader();
            //povezujemo grid i rezultat
            gvProducts.DataSource = _reader;
            gvProducts.DataBind();
            //zatvaramo konekcije prema bazi
            _reader.Close();
            _connection.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Products(name, description)VALUES(@name, @description)", _connection);
            _command.Parameters.AddWithValue("@name", tbNaziv.Text);
            _command.Parameters.AddWithValue("@description", tbOpis.Text);
            _command.ExecuteNonQuery(); // ništa ne vraća
            _connection.Close();
            Display();

        }

    }
}