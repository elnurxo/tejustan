using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class Color:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string HexValue { get; set; }
        public List<ShoeColor> ShoeColors { get; set; }
    }
}
