﻿using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repositery.IRepositery
{
    public interface ICoverTypeRepository : IRepositery<CoverType>
    {
        public void update(CoverType category);

    }
}
