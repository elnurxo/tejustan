using ElnurJUAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.ViewModels
{
    public class DashBoardViewModel
    {
        public List<Shoe> Shoes { get; set; }
        public List<Order> Orders { get; set; }
        public List<AppUser> AppUsers { get; set; }
        public List<Partnership> Partnerships { get; set; }
        public List<Message> Messages { get; set; }
    }
}
