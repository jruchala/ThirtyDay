﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirtyDay.Models;

namespace ThirtyDay.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Billy Jo",
                LastName = "McGuffery",
                BirthDate = new DateTime(1990, 6, 1),
                LikesMusic = true,
                EmailAddress = "Billy@jo.com",
                Skills = new List<string>() { "Math", "Science", "History" }

            };

            return View(person);
        }

        public ActionResult Create()
        {
            var person = new Person();
            return View(person);
        }
    }
}