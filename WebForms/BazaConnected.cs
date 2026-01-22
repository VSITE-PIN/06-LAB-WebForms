using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebForms
{
	public class BazaConnected
	{
		private readonly SqlConnection _connection = new
SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
		private SqlCommand _command;
		private SqlDataReader _dr;
	}
}