using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharp;

namespace PGSolution.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //temp data = 
            //view data = 
            //viewbag = dynamic
            //model binding
            // session
            // query string

            Student objStudent = new Student();
            ViewData["ViewMessage"] = objStudent.PrintStudentDetail(101, "Prabhas");
            return View();
        }

        // GET: Home
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

    }
}