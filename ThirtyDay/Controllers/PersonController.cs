using Angela.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirtyDay.Models;

namespace ThirtyDay.Controllers
{

    public class PersonController : Controller
    {
        private static ICollection<Person> _people;
        
        static PersonController()
        {
            _people = Angie.Configure<Person>()
                .Fill(p => p.BirthDate)
                .AsPastDate()
                .Fill(p => p.LikesMusic)
                .WithRandom(new List<bool>() { true, true, true, true, false, false })
                .Fill(p => p.Skills, () => new List<string>() { "Math", "Science", "History" })
                .MakeList<Person>(20);
        }
        // GET: Person
        public ActionResult Index()
        {
            return View(_people);
        }
    }
}