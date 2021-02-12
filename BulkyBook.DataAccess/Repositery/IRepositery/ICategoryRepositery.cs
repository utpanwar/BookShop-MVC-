using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public interface ICategoryRepositery : IRepositery<Category>
    {
        public void update(Category category);

    }
}
