using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlacementManagement.Models;

namespace PlacementManagement.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddDetails()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult AddDetails(Student s)
        {
            if (!ModelState.IsValid)
            {
                return View("AddDetails");
            }
            else {
                StudentContext context = new StudentContext();
                context.Students.Add(s);
                context.SaveChanges();
            return View("Index");
            }
        }
        public ActionResult Companies()
        {
            StudentContext context = new StudentContext();

            return View(context.Companies.ToList());
        }
    }
}