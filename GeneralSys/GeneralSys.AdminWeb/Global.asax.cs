using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GeneralSys.AdminWeb
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //注册IOC
            Ioc.InitIoc();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}