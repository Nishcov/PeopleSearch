using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopleSearch.Models;
using PeopleSearch.DTOs;
using AutoMapper;

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
        public IHttpActionResult GetPeople()
        {
            var personDTOs = context.People.ToList().Select(Mapper.Map<Person, PersonDTO>);

            return Ok(personDTOs);
        }

        // GET: /api/people/#
        public IHttpActionResult GetPerson(int id)
        {
            Person person = context.People.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Person, PersonDTO>(person));
        }

        // POST: /api/people
        [HttpPost]
        public IHttpActionResult AddPerson(PersonDTO personDTO)
        {
            // Validate first
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Person person = Mapper.Map<PersonDTO, Person>(personDTO);
            context.People.Add(person);
            context.SaveChanges();

            personDTO.Id = person.Id;

            return Created(new Uri(Request.RequestUri + "/" + person.Id), personDTO);
        }
    }
}
