using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new NavbarModel { User = LoggedUser };
            return View(model);
        }
        public ActionResult Contact()
        {
            var model = new NavbarModel { User = LoggedUser };
            return View(model);
        }

    }
}