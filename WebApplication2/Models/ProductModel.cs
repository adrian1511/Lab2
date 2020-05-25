using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProductModel : NavbarModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
    }
}