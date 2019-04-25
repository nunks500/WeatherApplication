namespace WeatherApplication.Models
{
    using System;
    using Newtonsoft.Json;

    public class WeatherCity
    {
        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("MinTemp")]
        public int MinTemp { get; set; }

        [JsonProperty("MaxTemp")]
        public int MaxTemp { get; set; }
    }
}