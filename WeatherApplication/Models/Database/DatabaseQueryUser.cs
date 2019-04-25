namespace WeatherApplication.Models.Database
{
    public static class DatabaseQueryUser
    {
        internal static User Login(User user)
        {
            string Command = "SELECT * FROM User WHERE Username = '" + user.Username + "'";
            var result = UserTableCreator.ReadData(Command);

            if (result.Count == 0)
                return null;

            if (DatabaseExtensions.CheckPasswordMatch(result[0].Password, user.Password))
                return result[0];
            else
                return null;
        }
    }
}