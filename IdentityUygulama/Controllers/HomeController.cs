using IdentityUygulama.Models;
using IdentityUygulama.Utility;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IdentityUygulama.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ApplicationUser user = null;
            ViewBag.Message = "Your application description page.";
            if (User.Identity.IsAuthenticated)
            {
                string id = User.Identity.GetUserId();
                user = db.Users.Find(id);
            }
            return View(user);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}