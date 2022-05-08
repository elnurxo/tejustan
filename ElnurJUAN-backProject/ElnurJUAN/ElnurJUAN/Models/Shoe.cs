using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Models
{
    public class Shoe:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 85)]
        public string Name { get; set; }
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }
        public bool IsAvailable { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        [Range(1, 5)]
        public int Rate { get; set; }
        public string CodePref { get; set; }
        public int CodeNum { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        [NotMapped]
        public List<int> ColorIds { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<ShoeComment> ShoeComments { get; set; }
        public List<ShoeColor> ShoeColors { get; set; }
        [NotMapped]
        public List<IFormFile> Files { get; set; }
        [NotMapped]
        public List<int> FileIds { get; set; } = new List<int>();
        public List<ShoeImage> ShoeImages { get; set; }
        [NotMapped]
        public List<Order> Orders { get; set; }
    }
}
