using System.Web.Mvc;
using GeneralSys.App;

namespace GeneralSys.AdminWeb.Controllers
{
    public class SysResourceController : BaseController
    {
        private readonly SysResourceManagerApp _resourceManagerApp;

        public SysResourceController()
        {
            _resourceManagerApp = Ioc.GetFromFac<SysResourceManagerApp>();
        }

        // GET: SysResource
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult GetZtreeData()
        {
            var resource = _resourceManagerApp.GetZTreeData(0);
            return Json(resource,JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取资源列表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAllResource(int pageCurrent = 1, int pageSize = 30)
        {
            var resource = _resourceManagerApp.GetAllResource(pageCurrent, pageSize);
            return Json(resource,JsonRequestBehavior.AllowGet);
        }

    }
}