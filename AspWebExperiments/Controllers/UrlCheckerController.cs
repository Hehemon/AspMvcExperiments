using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebExperiments.Controllers
{
    public class UrlCheckerController : Controller
    {
        // GET: UrlChecker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Status(string url)
        {
            throw new NotImplementedException();
        }
    }
}