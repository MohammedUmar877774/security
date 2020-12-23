using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace security.Controllers
{
    public class validController : Controller
    {
        // GET: valid
        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Models.validation v)
        {
            if (ModelState.IsValid)
                ViewBag.Result = "Form Submitted Successfully.";
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

    }
}