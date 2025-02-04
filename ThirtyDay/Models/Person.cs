﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ThirtyDay.Models
{
    public class Person
    {
        public Person()
        {
            Skills = new HashSet<string>();
            BirthDate = DateTime.Now.AddYears(-20);
        }
        public int PersonId { get; set; }


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [UIHint("BooleanButtonLabel")]
        public bool LikesMusic { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public ICollection<string> Skills { get; set; }
    }
}