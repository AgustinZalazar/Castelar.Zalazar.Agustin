using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML.Web.Controllers
{
    public class HtmlController : Controller
    {
        // GET: Html_Css
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HtmlView()
        {
            return View();
        }
    }
}