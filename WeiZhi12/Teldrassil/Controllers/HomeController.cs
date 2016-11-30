using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teldrassil.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {

            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "微知一二，成立于2015年。";

            return View();
        }

        public string Manage() {
            return "hello";
        }

        public ActionResult Contact() {
            ViewBag.Message = "请通过以下方式与我们取得联系。";

            return View();
        }
    }
}