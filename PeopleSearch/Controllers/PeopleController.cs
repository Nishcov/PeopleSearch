using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People/Random
        public ActionResult Random()
        {
            Person peep = new Person() { Name = "Ro" };

            return View(peep);
        }
    }
}