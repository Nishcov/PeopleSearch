using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleSearch.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        [Required]
        [StringLength(255)]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        [Range(1, 125)]
        public int Age { get; set; }

        [Required]
        [StringLength(255)]
        public string Interests { get; set; }

        public byte[] Picture { get; set; }
    }
}