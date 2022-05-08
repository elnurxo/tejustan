using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.ViewModels
{
    public class BasketViewModel
    {
        public List<ShoeBasketItemViewModel> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
