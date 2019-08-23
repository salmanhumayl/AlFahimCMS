using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlFahimCMS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username ,string password, string returnUrl)
        {

            if (username == "salesman" && password=="demo")
            {

                return RedirectToAction("List", "Customer");

            }
            if (username == "coordinator" && password == "demo")
            {
                return RedirectToAction("ViewOrders", "Order");


            }
            return View();
        }
    }
}