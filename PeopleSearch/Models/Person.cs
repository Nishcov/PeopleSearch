using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleSearch.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string[] Address { get; set; }
        public int Age { get; set; }
        public string[] Interests { get; set; }
        public System.Drawing.Image Picture { get; set; }
    }
}