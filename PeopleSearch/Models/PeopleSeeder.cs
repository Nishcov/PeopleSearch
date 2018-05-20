/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PeopleSearch.Models
{
    public class PeopleSeeder : CreateDatabaseIfNotExists<PeopleDbContext>
    {
        // Init database with seeded people data
        protected override void Seed(PeopleDbContext context)
        {
            base.Seed(context);

            List<Person> people = new List<Person>();

            people.Add(new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Fake St",
                Age = 39,
                Interests = new string[] { "Movies", "TV" }
                //Picture = new System.Drawing.Image();
            });

            people.Add(new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Address = "42 Galaxy Ln",
                Age = 42,
                Interests = new string[] { "Books", "Cooking" }
                //Picture = new System.Drawing.Image();
            });

            // Add each person to the context
            people.ForEach(person => context.People.Add(person));
     
            context.SaveChanges();
        }
    }
}

*/