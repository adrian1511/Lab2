using KoreanBeauty.BLL.DataTransfer;
using KoreanBeauty.BLL.Interfaces;
using KoreanBeauty.DAL.Entities;
using KoreanBeauty.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.BLL.API
{
    public class AdminAPI : API, IAdminAPI
    {
        public AdminAPI(IUnitOfWork database) : base(database)
        {
        }
        public void AddProduct(ProductDTO productDTO, string imageUrl, string directory)
        {
            var product = new Product { Name = productDTO.Name, Price = productDTO.Price, Discount = productDTO.Discount };
            Database.Products.Create(product);
            Database.Save();
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(imageUrl), directory + "/" + product.Id + ".jpg");
            }
        }
        public void DeleteProduct(int productId, string directory)
        {
            var product = Database.Products.Get(productId);
            var path = directory + "/" + product.Id + ".jpg";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Database.Products.Delete(product);
            Database.Save();
        }
    }
}
