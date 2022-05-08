using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{

    public class AppUser:IdentityUser
    {
        [StringLength(maximumLength: 150)]
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Shoe> ShoeComments { get; set; }
    }
}
