using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleDbContext context;

        public PeopleController()
        {
            context = new PeopleDbContext();
        }

        // Properly dispose of context when finished
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: People/New
        public ActionResult New()
        {
            return View();
        }

        // GET: People/Add
        [HttpPost]
        public ActionResult Add(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();

            return RedirectToAction("Index", "People");
        }

        // GET: People/Index
        public ViewResult Index()
        {
            List<Person> peeps = context.People.ToList();

            return View(peeps);
        }
    }
}
