namespace WeatherApplication
{
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using WeatherApplication.Models.Database;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            InitializeDB();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void InitializeDB()
        {
            WeatherTableCreator.CreateWeatherDatabase();
            UserTableCreator.CreateUserDatabase();
            WeatherTableCreator.InsertWeatherData();
            UserTableCreator.CreateSampleUsers();
        }
    }
}
