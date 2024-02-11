using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Gameflix.Areas.Cyberpunk2077.Controllers
{
    public class SeasonsController : Controller
    {
        // GET: Cyberpunk2077/Seasons
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}