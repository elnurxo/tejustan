using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class ShoeComment
    {
        public int Id { get; set; }
        public int ShoeId { get; set; }
        public string AppUserId { get; set; }
        [Range(1, 5)]
        public byte Rate { get; set; }
        [StringLength(maximumLength: 400)]
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public AppUser AppUser { get; set; }
        public List<ShoeImage> ShoeImages { get; set; }
        public Shoe Shoe { get; set; }
    }
}
