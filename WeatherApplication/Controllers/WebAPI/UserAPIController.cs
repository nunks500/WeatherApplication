namespace WeatherApplication.Controllers.WebAPI
{
    using System.Web.Http;
    using WeatherApplication.Models;
    using WeatherApplication.Models.Database;

    public class UserAPIController : ApiController
    {
        // POST: api/UserAPI
        [HttpPost]
        [Route("login/")]
        public User Post([FromBody]User user)
        {
              return DatabaseQueryUser.Login(user);
        }
    }
}
