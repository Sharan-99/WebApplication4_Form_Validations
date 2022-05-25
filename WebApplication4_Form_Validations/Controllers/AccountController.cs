using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4_Form_Validations.Models;

namespace WebApplication4_Form_Validations.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(RegistrationModel reg)
        {
            if (ModelState.IsValid)
                return Content("Signup successful");
            else
                return View(reg);
            
        }
    }
}