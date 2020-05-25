using KoreanBeauty.BLL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProductPageModel : NavbarModel
    {
        public ProductDTO Product { get; set; }
    }
}