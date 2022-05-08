using ElnurJUAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.ViewModels
{
    public class ShopViewModel
    {
        public List<Settings> Settings { get; set; }
        public List<Shoe> Shoes { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Color> Colors { get; set; }
        public List<int> FilterColorIds { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }

    }
}
