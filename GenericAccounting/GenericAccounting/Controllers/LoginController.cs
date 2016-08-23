using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BOL;
using BusinessLogic;

namespace GenericAccounting.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private SimpleMembershipProvider smp;

        public LoginController()
        {
            smp = new SimpleMembershipProvider();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(user auser)
        {
            if (smp.ValidateUser(auser.username, auser.password))
            {
                FormsAuthentication.SetAuthCookie(auser.username, false);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}