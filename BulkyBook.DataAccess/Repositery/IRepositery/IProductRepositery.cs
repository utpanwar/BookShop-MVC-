using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public interface IProductRepositery : IRepositery<Product>
    {
        public void update(Product product);

    }
}
