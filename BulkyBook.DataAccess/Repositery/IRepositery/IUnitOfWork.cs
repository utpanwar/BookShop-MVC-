using BulkyBook.DataAccess.Repositery.IRepositery;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public interface IUnitOfWork : IDisposable
    {
         ICategoryRepositery Category { get; }
         ICoverTypeRepository CoverType { get; }
        IProductRepositery Product { get; }
        ICompanyRepositery Company { get; }
        //IApplicationUserRepositery ApplicationUser { get; }
        ISP_Call SP_Call { get; } 
        //IShoppingCartRepository ShoppingCart { get; }
        //IOrderHeaderRepository OrderHeader { get; }
        //IOrderDetailsRepository OrderDetails { get; }


        void Save();
    }
}