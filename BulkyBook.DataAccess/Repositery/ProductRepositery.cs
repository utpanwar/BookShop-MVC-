using BookShop.DataAccess.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public class ProductRepositery : Repositery<Product> , IProductRepositery
    {
        private readonly ApplicationDbContext _db;
        public ProductRepositery(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Product product)
        {
            var objFromDb = _db.Product.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price100 = product.Price100;
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                objFromDb.CoverTypeId = product.CoverTypeId;

            }
        }
    }
}
