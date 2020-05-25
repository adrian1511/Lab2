﻿using KoreanBeauty.BLL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.BLL.Interfaces
{
    public interface IProductAPI
    {
        IEnumerable<ProductDTO> GetAllProducts();
        ProductDTO GetProduct(int productId);
    }
}
