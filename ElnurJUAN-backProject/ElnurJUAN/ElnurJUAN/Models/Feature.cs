using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [StringLength(maximumLength: 100)]
        public string Icon { get; set; }
        [StringLength(maximumLength: 120)]
        public string Desc { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
