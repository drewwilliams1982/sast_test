using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoIt(string unsafeSql)
        {
            var service = new DummyService();

            service.execute("select * from [sys].[all_views] where name='" + unsafeSql + "'");

            return this.PartialView("Index");
        }
    }
}