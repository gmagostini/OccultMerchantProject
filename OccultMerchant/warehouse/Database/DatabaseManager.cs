using System.Data;
using Microsoft.Data.Sqlite; //using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace warehouse.Database
{
    public static class DatabaseManager
    {
        public static string connectionStrin = "Data Source=../ItemsDatabase.sqlite";
        private static SqliteConnection connection = new SqliteConnection("Data Source=../ItemsDatabase.sqlite");
        
        /// <summary>
        /// restituisce la conesione al database. La apre se è chisa;
        /// </summary>
        /// <returns></returns>
        public static SqliteConnection getConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public static void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
    
}