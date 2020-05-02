using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            var account = new AccountConfig
            {
                User = new User
                {
                    Email = "kek@kek.kek",
                    NickName = "kek",
                    FirstName = "Lol",
                    LastName = "cheburek"
                }
            };
            return View(account);
        }
        public ActionResult LoginRegister()
        {
            return View();
        }
        public ActionResult Login(LoginRegisterModel model)
        {

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Register(LoginRegisterModel model)
        {
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(AccountConfig model)
        {
            return RedirectToAction("Index", "Home");
        }


    }
}