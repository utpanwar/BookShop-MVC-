using BulkyBook.DataAccess.Repositery.IRepositery;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
         ICategoryRepositery Category { get; }
        //ICoverTypeRepository CoverType { get; }
        //IProductRepository Product { get; }
        //ICompanyRepository Company { get; }
        //IApplicationUserRepository ApplicationUser { get; }
        ISP_Call SP_Call { get; }

        public int MyProperty { get; set; }
        string Name
        {
            get { return "Employee Name"; }
            set { }
        }


        //public int MyProperty { get; set; }

        //public int  Myproperty
        //{
        //    get;
        //    set;
        //}


        //int MyVar { get; set; }
        //int MyVar1 { get; set; }

        //IShoppingCartRepository ShoppingCart { get; }
        //IOrderHeaderRepository OrderHeader { get; }
        //IOrderDetailsRepository OrderDetails { get; }


        void Save();
    }
}