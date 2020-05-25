using KoreanBeauty.BLL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Attributes;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminController : BaseController
    {
        [Admin]
        public ActionResult Index()
        {
            var model = new AdminPageModel { Products=ProductAPI.GetAllProducts(), User = LoggedUser };
            return View(model);
        }
        [Admin]
        [HttpGet]
        public ActionResult AddProduct()
        {
            var model = new ProductModel { User = LoggedUser };
            return View(model);
        }
        [Admin]
        [HttpPost]
        public ActionResult AddProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new ProductDTO { Name = model.Name, Discount = model.Discount, Price = model.Price };
                var directory = Server.MapPath("~/Content/images/product");
                AdminAPI.AddProduct(product, model.ImageUrl, directory);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [Admin]
        public ActionResult DeleteProduct(int id)
        {
            var directory = Server.MapPath("~/Content/images/product");
            AdminAPI.DeleteProduct(id, directory);
            return RedirectToAction("Index");
        }
    }
}