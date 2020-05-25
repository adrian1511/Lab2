using KoreanBeauty.BLL;
using KoreanBeauty.BLL.DataTransfer;
using KoreanBeauty.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public abstract class BaseController : Controller
    {
        private BusinessLogic Bl { get; }

        protected BaseController()
        {
            Bl = new BusinessLogic();
        }

        protected IUserAPI UserAPI => Bl.UserAPI;
        protected IProductAPI ProductAPI => Bl.ProductAPI;
        protected IAdminAPI AdminAPI => Bl.AdminAPI;
        protected UserDTO LoggedUser => UserAPI.GetUser(User.Identity.Name);

    }
}