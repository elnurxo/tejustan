using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class ShoeImage
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        public int ShoeId { get; set; }
        public bool? PosterStatus { get; set; }
        public Shoe Shoe { get; set; }
    }
}
