using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace WebFormsLab6
{

    public static class Db
    {
        private static string ConnStr =>
            ConfigurationManager.ConnectionStrings["WebFormsLabosConn"].ConnectionString;

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static DataTable GetDataTable(string sql, params SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();

                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
