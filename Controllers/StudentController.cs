using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlacementManagement.Models;

namespace PlacementManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login l)
        {
            

            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            else
            {

                var c = l.UserName;
                var p = l.Password;
                 StudentContext context = new StudentContext();
                 context.logins.Add(l);
                 context.SaveChanges();
                if (c == "admin")
                {
                    if (p == "admin123")
                    {
                        return RedirectToAction("Index","Admin");
                    }
                    else
                    {

                        return View("login");
                    }
                }
                else if (c == "user")
                {
                    if (p == "user123")
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {

                        return View("login");
                    }
                }
                else
                {
                    return View("login");
                }
                
            }
           

            
        }
       
        
    }
}