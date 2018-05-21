using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers.API
{
    public class PeopleController : ApiController
    {
        private PeopleDbContext context;

        public PeopleController()
        {
            context = new PeopleDbContext();
        }

        // GET: /api/people
        public IEnumerable<Person> GetPeople()
        {
            return context.People.ToList();
        }

        // GET: /api/people/#
        public Person GetPerson(int id)
        {
            Person person = context.People.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return person;
        }

        // POST: /api/people
        [HttpPost]
        public Person AddPerson(Person person)
        {
            // Validate first
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            context.People.Add(person);
            context.SaveChanges();

            return person;
        }
    }
}
