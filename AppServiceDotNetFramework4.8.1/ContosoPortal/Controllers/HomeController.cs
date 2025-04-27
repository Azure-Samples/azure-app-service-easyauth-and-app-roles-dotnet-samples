using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ContosoPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Claims = ClaimsPrincipal.Current.Claims;
            return View();
        }
        // ENV variables WEBSITE_AUTH_USE_LEGACY_CLAIMS needs to set as false in App Service
        // before App Roles will work due to the format of the "roles" claims
        // https://learn.microsoft.com/en-us/azure/app-service/reference-app-settings?tabs=kudu%2Cdotnet
        [Authorize(Roles = "Member")]
        public ActionResult MemberArea()
        {
            ViewBag.Message = "Only users with the app role Member can see this page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}