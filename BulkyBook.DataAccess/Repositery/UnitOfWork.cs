using BookShop.DataAccess.Data;
using BulkyBook.DataAccess.Repositery;
using BulkyBook.DataAccess.Repositery.IRepositery;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepositery(_db);
            //CoverType = new CoverTypeRepository(_db);
            //Company = new CompanyRepository(_db);
            //Product = new ProductRepository(_db);
            //ApplicationUser = new ApplicationUserRepository(_db);
            SP_Call = new SP_Call(_db);
            MyPropertys = new CategoryRepositery(_db);
            //MyProperty = 5;
            //OrderDetails = new OrderDetailsRepository(_db);
            //OrderHeader = new OrderHeaderRepository(_db);
            //ShoppingCart = new ShoppingCartRepository(_db);
        }

        //public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICategoryRepositery Category { get; }

        public ISP_Call SP_Call { get; }

        public Repositery<Category> MyPropertys { get ; set; }
        int IUnitOfWork.MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public ICompanyRepository Company { get; private set; }
        //public IProductRepository Product { get; private set; }
        //public ICoverTypeRepository CoverType { get; private set; }
        //public IShoppingCartRepository ShoppingCart { get; private set; }
        //public IOrderDetailsRepository OrderDetails { get; private set; }
        //public IOrderHeaderRepository OrderHeader { get; private set; }
        //public ISP_Call SP_Call { get; private set; }

        public int slim { get; set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}