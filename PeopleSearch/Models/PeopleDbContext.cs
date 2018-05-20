using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PeopleSearch.Models
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}