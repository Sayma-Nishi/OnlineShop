﻿using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }
        //Create Get action Method
        public ActionResult Create() 
        {
            return View();
        }
        //Create Post action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }

        //Create  Edit Action Method
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var productTypes = _db.ProductTypes.Find(id);
            if (productTypes == null)
            { return NotFound(); 
            }
            return View(productTypes);
        }
        //Create Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }

        //Create  Details Action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productTypes = _db.ProductTypes.Find(id);
            if (productTypes == null)
            {
                return NotFound();
            }
            return View(productTypes);
        }
        //Create Details action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes productTypes)
        {
            return RedirectToAction(nameof(Index));
            
        }

        //Create  Delete Action Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productTypes = _db.ProductTypes.Find(id);
            if (productTypes == null)
            {
                return NotFound();
            }
            return View(productTypes);
        }
        //Create Delete action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, ProductTypes productTypes)
        {
            if(id == null) 
            {
                return NotFound(); 
            }
            if(id! == productTypes.Id)
            { 
                return NotFound(); 
            }
            var productType=_db.ProductTypes.Find(id);
            if(productType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
    }
}
