using KoreanBeauty.BLL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AdminPageModel : NavbarModel
    {
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}