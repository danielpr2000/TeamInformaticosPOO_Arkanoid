using System.Data;
using Npgsql;

namespace Arkanoid
{
    public static class ConnectionDB
    {
        private static string Connection = "Server= 127.0.0.1;" +
                                           "Port=5432;" +
                                           "User Id = postgres" +
                                           "Password=pau" +
                                           "Database=proyectoArkanoid";
       
        public static DataTable ExecuteQuery(string query){
            
            NpgsqlConnection connection = new NpgsqlConnection(Connection);
          DataSet ds = new DataSet();
          
          connection.Open();
          
          NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
          da.Fill(ds);
          
          connection.Close();

          return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Connection);
            
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}