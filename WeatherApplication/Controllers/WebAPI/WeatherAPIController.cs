namespace WeatherApplication.Controllers.WebAPI
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Results;
    using WeatherApplication.Models;
    using WeatherApplication.Models.Database;

    public class WeatherAPIController : ApiController
    {
        // GET: api/WeatherAPI
        [HttpGet]
        [Route("getWeatherByDate/{city}/{day:dateTime}")]
        public JsonResult<WeatherCity> Get(string city, DateTime day)
        {
            return this.Json(DatabaseQueryWeather.getWeatherByDayAndCity(city,day));
        }

        [HttpGet]
        [Route("getWeatherByDate/{day:dateTime}")]
        public JsonResult<List<WeatherCity>> Get(DateTime day)
        {
            return this.Json(DatabaseQueryWeather.getWeatherByDayForAllCities(day));
        }

        [HttpGet]
        [Route("getWeatherByDate/")]
        public JsonResult<List<WeatherCity>> Get()
        {
            return this.Json(DatabaseQueryWeather.getWeatherForAllCitiesAndAllDays());
        }

        // POST: api/WeatherAPI
        [HttpPost]
        [Route("addWeatherDay/")]
        public HttpResponseMessage Post([FromBody] WeatherCity weathercityModel)
        {
            DatabaseQueryWeather.addWeatherForACity(weathercityModel);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
