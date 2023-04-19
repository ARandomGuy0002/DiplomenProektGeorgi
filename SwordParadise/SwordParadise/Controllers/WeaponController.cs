using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwordParadise.Abstraction;
using SwordParadise.Domain;
using SwordParadise.Models.Brand;
using SwordParadise.Models.Category;
using SwordParadise.Models.Weapon;
using SwordParadise.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwordParadise.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class WeaponController : Controller
    {
        private readonly IWeaponService _weaponService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        public WeaponController(IWeaponService weaponService, ICategoryService categoryService, IBrandService brandService) 
        {
            this._weaponService = weaponService;
            this._categoryService = categoryService;
            this._brandService = brandService;
        }
        public ActionResult Create()
        {
            var weapon = new WeaponCreateVM();
            weapon.Brands = _brandService.GetBrands()
                .Select(x => new BrandPairVM()
                {
                    Id = x.Id,
                    Name = x.BrandName
                }).ToList();
            weapon.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                }).ToList();
            return View(weapon);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] WeaponCreateVM weapon)
        {
            if (ModelState.IsValid) 
            {
                var createdId = _weaponService.Create(weapon.WeaponName, weapon.BrandId, weapon.CategoryId, weapon.Picture, weapon.Quantity, weapon.Description, weapon.Price, weapon.Discount);
                if (createdId)
                {
                    return this.RedirectToAction("CreateSuccess"); 
                }
            }
            return View();

        }
        [AllowAnonymous]
        public ActionResult Index(string searchStringCategoryName, string searchStringBrandName, string searchStringWeaponName) 
        {
            List<WeaponIndexVM> weapons = _weaponService.GetWeapons(searchStringCategoryName, searchStringBrandName, searchStringWeaponName)
            .Select(weapon => new WeaponIndexVM 
            {
                Id = weapon.Id,
                WeaponName= weapon.WeaponName,
                BrandId= weapon.BrandId,
                BrandName = weapon.Brand.BrandName,
                CategoryId= weapon.CategoryId,
                CategoryName= weapon.Category.CategoryName,
                Picture= weapon.Picture,
                Quantity= weapon.Quantity,
                Description= weapon.Description,
                Price= weapon.Price,
                Discount= weapon.Discount
            }).ToList();
            return this.View(weapons);
        }
        public ActionResult Edit(int id)
        {
            Weapon weapon = _weaponService.GetWeaponById(id);
            if (weapon == null)
            { return NotFound(); }

            WeaponEditVM updatedWeapon = new WeaponEditVM()
            {
                Id = weapon.Id,
                WeaponName = weapon.WeaponName,
                BrandId = weapon.BrandId,
                CategoryId = weapon.CategoryId,
                Picture = weapon.Picture,
                Quantity = weapon.Quantity,
                Description = weapon.Description,
                Price = weapon.Price,
                Discount = weapon.Discount
            };

            updatedWeapon.Brands = _brandService.GetBrands()
                .Select(b => new BrandPairVM()
                {
                    Id = b.Id,
                    Name = b.BrandName
                }).ToList();

            updatedWeapon.Categories = _categoryService.GetCategories()
                .Select(c => new CategoryPairVM()
                {
                    Id = c.Id,
                    Name = c.CategoryName
                }).ToList();
            return View(updatedWeapon);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WeaponEditVM weapon)
        {
            if (ModelState.IsValid)
            {
                var updated = _weaponService.Update(id, weapon.WeaponName, weapon.BrandId,
                    weapon.CategoryId, weapon.Picture, weapon.Quantity, weapon.Description, 
                    weapon.Price, weapon.Discount);

                if (updated)
                {
                    return this.RedirectToAction("Index");
                }
            }
            return View(weapon);
        }
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Weapon item = _weaponService.GetWeaponById(id);
            if (item == null)
            {
                return NotFound();
            }
            WeaponDetailsVM weapon = new WeaponDetailsVM()
            {
                Id = item.Id,
                WeaponName = item.WeaponName,
                BrandId = item.BrandId,
                BrandName = item.Brand.BrandName,
                CategoryId = item.CategoryId,
                CategoryName = item.Category.CategoryName,
                Picture = item.Picture,
                Quantity = item.Quantity,
                Description = item.Description,
                Price = item.Price,
                Discount = item.Discount
            };
            return View(weapon);
        }

        public ActionResult Delete(int id)
        {
            Weapon weapon = _weaponService.GetWeaponById(id);
            if (weapon == null)
            { return NotFound(); }

            WeaponDeleteVM productDelete = new WeaponDeleteVM()
            {
                Id = weapon.Id,
                WeaponName = weapon.WeaponName,
                BrandId = weapon.BrandId,
                BrandName = weapon.Brand.BrandName,
                CategoryId = weapon.CategoryId,
                CategoryName = weapon.Category.CategoryName,
                Picture = weapon.Picture,
                Quantity = weapon.Quantity,
                Description = weapon.Description,
                Price = weapon.Price,
                Discount = weapon.Discount
            };
            return View(productDelete);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _weaponService.RemoveById(id);
            if (deleted)
            {
                return this.RedirectToAction("DeleteSuccess");
            }
            else { return View(); }
        }
        public IActionResult CreateSuccess()
        { return this.View(); }
        public IActionResult DeleteSuccess()
        { return this.View(); }
    }
}
