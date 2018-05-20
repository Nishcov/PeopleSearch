using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;
//using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleDbContext database = new PeopleDbContext();

        // GET: People/Random
        public ActionResult Random()
        {
            Person person = new Person() { FirstName = "Orick" };

            return View(person);
        }

        /*
        // Properly dispose of PeopleContext resources
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.database.Dispose();
            }

            base.Dispose(disposing);
        }

        protected void GetInput(object sender, EventArgs e)
        {
            //string name = Request.
        }

        // Helper that gets person from database
        private Person GetPerson(string name)
        {
            // Look for matching first or last name
            var peep = this.database.People
                .Where(person => person.FirstName == name || person.LastName == name);

            return this.database.People.Find(name);
        }

        // GET: api/Search
        [HttpGet]
        public IHttpActionResult Search()
        {
            string name = "John";

            // Use GetPerson helper to look for person's name
            Person person = this.GetPerson(name);

            // If no matching people found, return NotFound Error
            if (person == null)
            {
                return this.NotFound();
            }

            return this.Ok(person);
        }

        // Helper that adds a person to the database
        private void AddPerson(Person person)
        {
            this.database.People.Add(person);

            this.database.SaveChanges();
        }

        // POST: api/Add
        [HttpPost]
        public IHttpActionResult Add(Person person)
        {
            bool added = false;

            AddPerson(person);

            return this.Ok(added);
        }
        */
    }
}
