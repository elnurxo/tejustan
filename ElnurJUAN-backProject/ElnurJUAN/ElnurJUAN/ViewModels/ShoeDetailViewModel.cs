using ElnurJUAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.ViewModels
{
    public class ShoeDetailViewModel
    {
        public Shoe Shoe { get; set; }
        public List<Shoe> RelatedShoes { get; set; }
        public ShoeComment Comment { get; set; }
    }
}
