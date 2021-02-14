﻿using BulkyBook.DataAccess.Repository;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UnitOfWork unitOfWorks;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if(id==null)
            {
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
                       _unitOfWork.Category.update(category);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
            
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            var allObj2 = unitOfWorks.Category.GetAll();
            var d = unitOfWorks.slim;
            var a = _unitOfWork.Name;
             _unitOfWork.MyProperty = 10;
            return Json(new { data = allObj});
        }
        #endregion
    }
}