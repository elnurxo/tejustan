using ElnurJUAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Settings> Settings { get; set; }
        public List<Partnership> Partnerships { get; set; }
        public List<Shoe> Shoes { get; set; }
        public List<Shoe> MostRatedShoes { get; set; }

    }
}
