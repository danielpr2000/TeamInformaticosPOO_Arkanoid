using System.Data;
using Npgsql;

namespace Arkanoid
{
    public static class ConnectionDB
    {
        private static string host = "127.0.0.1", database = "ProyectoArkanoid", userId = "postgres", 
            password = "danielpr";
        
        private static string Connection =
            $"Server = {host}; Port = 5432; User Id = {userId}; Password = {password}; Database = {database};";
        
        
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(Connection);
            DataSet ds = new DataSet();
                               
            connection.Open();
                    
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
                    
            connection.Close();
        
            return ds.Tables[0];
        }
        
        public static void ExecuteNonQuery(string action)
        {
            NpgsqlConnection connection = new NpgsqlConnection(Connection);
        
            connection.Open();
        
            NpgsqlCommand command = new NpgsqlCommand(action, connection);
            command.ExecuteNonQuery();
        
            connection.Close();
        
        }
    }
}
