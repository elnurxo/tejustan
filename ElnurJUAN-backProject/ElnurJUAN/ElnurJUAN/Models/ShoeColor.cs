using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class ShoeColor
    {
        public int Id { get; set; }
        public int ShoeId { get; set; }
        public int ColorId { get; set; }
        public Shoe Shoe { get; set; }
        public Color Color { get; set; }
    }
}
