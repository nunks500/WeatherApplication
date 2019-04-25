namespace WeatherApplication.Models.Database
{
    using System.Collections.Generic;
    using System.Data.SQLite;

    public static class WeatherTableCreator
    {
        public static void CreateWeatherDatabase()
        {
            const string Createsql = "CREATE TABLE IF NOT EXISTS Weather " +
                "(City VARCHAR(20) NOT NULL," +
                " Date DATE NOT NULL," +
                " MinTemp int NOT NULL," +
                " MaxTemp int NOT NULL," +
                " primary key (Date, City))";
            var sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void InsertWeatherData()
        {
            var sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO Weather(City, Date, MinTemp, MaxTemp)" +
                " VALUES('Kraków', date('2019-04-20'), 5, 20); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO Weather(City, Date, MinTemp, MaxTemp)" +
                " VALUES('Warsaw', date('2000-01-01'), 2, 17); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT OR REPLACE INTO Weather(City, Date, MinTemp, MaxTemp)" +
                " VALUES('Wroclaw', date('2019-01-03'), 3, 14); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        public static List<WeatherCity> ReadData(string CommandText)
        {
            List<WeatherCity> result = new List<WeatherCity>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = ConnectorDatabase.sqliteConnection.CreateCommand();
            sqlite_cmd.CommandText = CommandText;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                var row = new WeatherCity();
                row.City = sqlite_datareader.GetString(0);
                row.Date = sqlite_datareader.GetDateTime(1);
                row.MinTemp = sqlite_datareader.GetInt32(2);
                row.MaxTemp = sqlite_datareader.GetInt32(3);

                result.Add(row);
            }

            return result;
        }
    }
}