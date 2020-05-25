using KoreanBeauty.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Product> Products { get; }
        IRepository<CartProduct> CartProducts { get; }
        void Save();
    }
}
