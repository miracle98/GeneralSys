using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneralSys.App;

namespace GeneralSys.AdminWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly SysResourceManagerApp _app;

        public HomeController()
        {
            _app = Ioc.GetFromFac<SysResourceManagerApp>();
        }

        // GET: Home
        public ActionResult Index()
        {
            var resource = _app.GetAllResource();
            return View(resource);
        }

        public ActionResult Main()
        {
            return View();
        }
    }
}