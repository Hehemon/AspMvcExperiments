using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspExperiments.Core.UrlChecker;
using AspWebExperiments.DependencyResolution;
using AspWebExperiments.ModelBuilders.UrlChecker;

namespace AspWebExperiments.Controllers
{
    public class UrlCheckerController : Controller
    {
        private readonly IUrlCheckerResultModelBuilder _urllCheckerResultModelBuilder;

        public UrlCheckerController(IUrlCheckerResultModelBuilder urllCheckerResultModelBuilder)
        {
            _urllCheckerResultModelBuilder = urllCheckerResultModelBuilder;
        }

        // GET: UrlChecker
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Statuses(string[] urls)
        {
            var model = _urllCheckerResultModelBuilder.GetViewModel(urls);
            return View("Statuses", model);
        }

        public ActionResult Status(string url)
        {
            return Statuses(new[] {url});
        }
    }
}