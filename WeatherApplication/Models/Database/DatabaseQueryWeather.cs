namespace WeatherApplication.Models.Database
{
    using System;
    using System.Collections.Generic;

    public static class DatabaseQueryWeather
    {
        internal static WeatherCity getWeatherByDayAndCity(string city, DateTime day)
        {
            string Command = "SELECT * FROM Weather WHERE City = '" + city + "' AND Date = '" + day.ToString("yyy-MM-dd") + "'";
            var result = WeatherTableCreator.ReadData(Command);

            return result.Count > 0 ? result[0] : null;
        }

        internal static List<WeatherCity> getWeatherByDayForAllCities(DateTime day)
        {
            string Command = "SELECT * FROM Weather WHERE Date = '" + day.ToString("yyy-MM-dd") + "'";
            var result = WeatherTableCreator.ReadData(Command);

            return result.Count > 0 ? result : null;
        }

        internal static void addWeatherForACity(WeatherCity weathercityModel)
        {
            string Command = "INSERT OR REPLACE INTO Weather(City, Date, MinTemp, MaxTemp)" +
                " VALUES('" + weathercityModel.City + "', date('" + weathercityModel.Date.ToString("yyy-MM-dd") + "')," + weathercityModel.MinTemp + "," +
            weathercityModel.MaxTemp + ");";

            WeatherTableCreator.ReadData(Command);

            return;
        }

        internal static List<WeatherCity> getWeatherForAllCitiesAndAllDays()
        {
            string Command = "SELECT * FROM Weather";
            var result = WeatherTableCreator.ReadData(Command);

            return result.Count > 0 ? result : null;
        }
    }
}