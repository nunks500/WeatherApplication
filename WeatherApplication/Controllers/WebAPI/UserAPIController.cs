namespace WeatherApplication.Controllers.WebAPI
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Results;
    using WeatherApplication.Models;
    using WeatherApplication.Models.Database;

    public class UserAPIController : ApiController
    {
        // POST: api/UserAPI
        [HttpPost]
        [Route("login/")]
        public User Post([FromBody]User user)
        {
            /*var response = Request.CreateResponse(HttpStatusCode.Moved);
            response.Headers.Location = new Uri("http://www.abcmvc.com");
            return response;*/
              return DatabaseQueryUser.Login(user);

        }
    }
}
