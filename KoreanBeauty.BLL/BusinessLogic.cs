using KoreanBeauty.BLL.API;
using KoreanBeauty.BLL.Interfaces;
using KoreanBeauty.DAL;
using KoreanBeauty.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.BLL
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {
            Database = new UnitOfWork("KoreanBeauty");
        }

        IUnitOfWork Database { get; }

        IUserAPI userAPI;
        IProductAPI productAPI;
        IAdminAPI adminAPI;

        public IUserAPI UserAPI
        {
            get
            {
                if (userAPI == null)
                    userAPI = new UserAPI(Database);
                return userAPI;
            }
        }
        public IProductAPI ProductAPI
        {
            get
            {
                if (productAPI == null)
                    productAPI = new ProductAPI(Database);
                return productAPI;
            }
        }
        public IAdminAPI AdminAPI
        {
            get
            {
                if (adminAPI == null)
                    adminAPI = new AdminAPI(Database);
                return adminAPI;
            }
        }
    }
}
