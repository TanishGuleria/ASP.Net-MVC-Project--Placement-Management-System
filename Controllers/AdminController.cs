using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlacementManagement.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace PlacementManagement.Controllers
{
    public class AdminController : Controller
    {
        StudentContext context = new StudentContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slist()
        {


            return View(context.Students.ToList());
        }
        public ActionResult Companies()
        {


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

                context.Companies.Add(c);
                context.SaveChanges();
                return RedirectToAction("Companies");
            }
        }

        public ActionResult DeleteStudent(int id)
        {
            Student s = context.Students.Find(id);
            context.Students.Remove(s);
            context.SaveChanges();
            return RedirectToAction("Slist");

        }

        public ActionResult DeleteCompany(int id)
        {
            Companies c = context.Companies.Find(id);
            context.Companies.Remove(c);
            context.SaveChanges();
            return RedirectToAction("Companies");
        }
        public ActionResult EditCompany(int id)
        {
            Companies c = context.Companies.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult EditCompany(Companies c)
        {

            context.Companies.AddOrUpdate(c);
            context.SaveChanges();
            return RedirectToAction("Companies");
        }
      
    }
}