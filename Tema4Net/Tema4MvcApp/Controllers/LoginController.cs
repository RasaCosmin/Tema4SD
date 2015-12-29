using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tema4MvcApp.Models;

namespace Tema4MvcApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return LogOff();// RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginUser loginUser)
        {
            var login = new LoginWebService.LoginWSClient();
            var result = login.Login(loginUser.Username, loginUser.Password);

            if(!result.Equals("failed"))
            {
                var user = JsonConvert.DeserializeObject<UserModel>(result);
                if (user.role.Equals("admin"))
                {
                    Session["role"] = "Administrator";
                }
                else if (user.role.Equals("client"))
                {
                    Session["role"] = "Client";
                }

                Session["userId"] = user.id;

                FormsAuthentication.SetAuthCookie(user.username, true);
                return RedirectToAction("index", "Home");

            }

            ViewBag.Mess = "Don't match any account! Please Register first!";
            return View(loginUser);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Remove("role");
            Session.Remove("userId");
            return RedirectToAction("Index", "Home");
        }
    }
}