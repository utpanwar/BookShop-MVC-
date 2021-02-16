using BookShop.DataAccess.Data;
using BulkyBook.DataAccess.Repositery;
using BulkyBook.DataAccess.Repositery.IRepositery;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repositery
{
    public class CompanyRepositery : Repositery<Company>, ICompanyRepositery
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepositery(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);
        }
    }
}
