using Foundation4MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foundation4MVC.Controllers
{
    public class FoundationController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC with Foundation 3.0.9!";

            return View();
        }

        public ActionResult Form()
        {
            var basicForm = new BasicFormModel();
            var items = new List<string>();
            items.Add("Option A");
            items.Add("Option B");
            items.Add("Option C");
            items.Add("Option D");

            basicForm.DropDownItems = new SelectList(items);

            return View(basicForm);
        }

        [HttpPost]
        public ActionResult Form(BasicFormModel basicForm)
        {
            var items = new List<string>();
            items.Add("Option A");
            items.Add("Option B");
            items.Add("Option C");
            items.Add("Option D");

            basicForm.DropDownItems = new SelectList(items);

            return View(basicForm);
        }

    }
}
