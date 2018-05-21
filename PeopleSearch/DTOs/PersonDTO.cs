using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PeopleSearch.Models;

namespace PeopleSearch.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
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