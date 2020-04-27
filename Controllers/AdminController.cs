using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlacementManagement.Models;

namespace PlacementManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slist()
        {
            StudentContext context = new StudentContext();

            return View(context.Students.ToList());
        }
        public ActionResult Companies()
        {
            StudentContext context = new StudentContext();

            return View(context.Companies.ToList());
        }
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Companies c)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCompany");
            }
            else
            {
                StudentContext context = new StudentContext();
                context.Companies.Add(c);
                context.SaveChanges();
                return RedirectToAction("Companies");
            }
        }
      
    }
}