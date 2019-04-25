namespace WeatherApplication.Models.Database
{
    using System.Collections.Generic;
    using System.Data.SQLite;

    public static class UserTableCreator
    {
        public static void CreateUserDatabase()
        {
            const string Createsql = "CREATE TABLE IF NOT EXISTS User " +
                "(Password VARCHAR(30) NOT NULL," +
                " Username VARCHAR(20) NOT NULL UNIQUE," +
                " Admin int NOT NULL," +
                " ID INTEGER PRIMARY KEY AUTOINCREMENT)";
            var sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void CreateSampleUsers()
        {
            var hashedPassword = DatabaseExtensions.HashPassword("password");
            var hashedPasswordAdmin = DatabaseExtensions.HashPassword("admin");

            var sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO User(Password, Username, Admin)" +
                " VALUES('" + hashedPassword + "', 'User1', 0); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO User(Password, Username, Admin)" +
                " VALUES('" + hashedPassword + "', 'User2', 0); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO User(Password, Username, Admin)" +
                " VALUES('" + hashedPasswordAdmin + "', 'admin', 1); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        public static List<User> ReadData(string CommandText)
        {
            List<User> result = new List<User>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = CommandText;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                var row = new User();
                row.Username = sqlite_datareader.GetString(1);
                row.Password = sqlite_datareader.GetString(0);
                row.Admin = sqlite_datareader.GetInt32(2);

                result.Add(row);
            }

            return result;
        }
    }
}