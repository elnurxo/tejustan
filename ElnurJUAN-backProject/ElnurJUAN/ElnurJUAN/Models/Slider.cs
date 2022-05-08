using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class Slider:BaseEntity
    {
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [StringLength(maximumLength: 65)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 65)]
        public string Title2 { get; set; }
        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 40)]
        public string BtnText { get; set; }
        [StringLength(maximumLength: 250)]
        public string BtnUrl { get; set; }
        public byte Order { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
