using MVCRockers.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    //I could place a tag here for example put a controller level filter for Authorization
    //[Authorize]
    //[Authorize(Roles = "Admin", Users ="Mike")]
    public class HomeController : Controller
    {
        //Home/Index 
        public ActionResult Index()
        {
            return View();
        }

        //Cache a page
        //[OutputCache(Duration =1800)]
        //Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[HandleError(Exception = typeof(DivideByZeroException), View = "MathError")]
        public ActionResult foo()
        {
            return View("About");
        }

        [MyLoggingFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "What do you think?";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: save this and act on it
            ViewBag.Message = "Thanks for the feedback!";
            return View();
        }

        public ActionResult Backstage( string secret, string format)
        {
            if ( secret != "special")
            {
                return new HttpStatusCodeResult(403);
            }

            else if(format == "text")
            {
                return Content("You Rock");
            }

            else if(format == "json")
            {
                return Json(new { password = "You Rock!", expires = DateTime.UtcNow.ToShortDateString() },
                    JsonRequestBehavior.AllowGet); 
            }

            else if(format == "clean")
            {
                return PartialView();
            }

            else
            return View();
        }
    }
}