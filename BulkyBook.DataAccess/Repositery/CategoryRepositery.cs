using BookShop.DataAccess.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public class CategoryRepositery : Repositery<Category>, ICategoryRepositery
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepositery(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;

            }
        }
    }
}
