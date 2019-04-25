namespace WeatherApplication.Models
{
    using System;
    using System.Data.SQLite;

    public static class ConnectorDatabase
    {
        public static readonly SQLiteConnection sqliteConnection = ConnectorDatabase.CreateConnection();

        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:

            sqlite_conn = new SQLiteConnection("Data Source= " + AppDomain.CurrentDomain.BaseDirectory + "/database.db; Version = 3; New = True; Compress = True;", true);

            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                throw;
            }
            return sqlite_conn;
        }
    }
}