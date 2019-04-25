namespace WeatherApplication.Models
{
    using Newtonsoft.Json;

    public class User
    {
        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Admin")]
        public int Admin { get; set; }

    }
}