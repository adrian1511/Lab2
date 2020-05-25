using KoreanBeauty.BLL.DataTransfer;
using KoreanBeauty.BLL.Interfaces;
using KoreanBeauty.DAL.Entities;
using KoreanBeauty.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.BLL.API
{
    public class ProductAPI : API, IProductAPI
    {
        public ProductAPI(IUnitOfWork database) : base(database)
        {
        }

        static internal ProductDTO ConvertToDTO(Product product)
        {
            if (product == null)
                return null;
            return new ProductDTO
            {
                Id = product.Id,
                Discount = product.Discount,
                Name = product.Name,
                Price = product.Price
            };
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return Database.Products.GetAll().ToList().ConvertAll(ConvertToDTO);
        }

        public ProductDTO GetProduct(int productId)
        {
            return ConvertToDTO(Database.Products.Get(productId));
        }
    }
}
