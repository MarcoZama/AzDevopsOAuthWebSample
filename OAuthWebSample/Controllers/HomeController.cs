using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OAuthSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ClientAppId = System.Configuration.ConfigurationManager.AppSettings["ClientAppId"];
            ViewBag.CallbackUrl = System.Configuration.ConfigurationManager.AppSettings["CallbackUrl"];
            ViewBag.Scope = System.Configuration.ConfigurationManager.AppSettings["Scope"];
            var scopesEscaped = System.Configuration.ConfigurationManager.AppSettings["Scope"].Replace(" ", "%20");
            ViewBag.AuthorizeUri = $"https://app.vssps.visualstudio.com/oauth2/authorize?client_id={System.Configuration.ConfigurationManager.AppSettings["ClientAppId"]}&response_type=Assertion"+
                                   $"&state=User1&scope={scopesEscaped}"+
                                   $"&redirect_uri={System.Configuration.ConfigurationManager.AppSettings["CallbackUrl"]}";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
          
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}