using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - The Tech Academy";

            return View();
        }

        public ActionResult Instructors()
        {
            List<Models.Instructor> instructors = new List<Models.Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    Id = 1,
                    FirstName = "Brett",
                    LastName = "Calendar",
                },
                new Instructor
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };

            return View(instructors);
        }
    }

           

      