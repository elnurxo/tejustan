using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class JuanContext : IdentityDbContext
    {
        public JuanContext(DbContextOptions<JuanContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Partnership> Partnerships { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ShoeColor> ShoeColors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ShoeImage> ShoeImages { get; set; }
        public DbSet<ShoeComment> ShoeComments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
