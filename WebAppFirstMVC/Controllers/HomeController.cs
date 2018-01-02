using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirstMVC.Models;

namespace WebAppFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: About
        public ActionResult About()
        {
            Person me = new Person(43, "Andreas Liljenberg");
            return View(me);
        }


        // GET: People
        public ActionResult People()
        {
            Person.People = new List<Person>();
            Person.People.Add(new Person(40, "Fredrik"));
            Person.People.Add(new Person(32, "Ali"));
            Person.People.Add(new Person(26, "Irma"));
            return View();
        }

    }
}