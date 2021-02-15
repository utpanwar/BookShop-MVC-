using BookShop.DataAccess.Data;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public class CoverTypeRepository : Repositery<CoverType> ,ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(CoverType coverType)
        {
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;

            }
        }
    }
}
