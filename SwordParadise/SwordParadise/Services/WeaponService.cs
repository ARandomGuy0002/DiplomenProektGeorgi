using SwordParadise.Abstraction;
using SwordParadise.Data;
using SwordParadise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwordParadise.Services
{
    public class WeaponService : IWeaponService
    {
        private readonly ApplicationDbContext _context;
        public WeaponService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(string name, int brandId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount)
        {
            Weapon item = new Weapon
            {
                WeaponName = name,
                Brand = _context.Brands.Find(brandId),
                Category = _context.Categories.Find(categoryId),
                Picture = picture,
                Quantity = quantity,
                Description = description,
                Price = price,
                Discount = discount
            };
            _context.Weapons.Add(item);
            return _context.SaveChanges() != 0;
        }
        public Weapon GetWeaponById(int weaponId)
        {
            return _context.Weapons.Find(weaponId);
        }
        public List<Weapon> GetWeapons()
        {
            List<Weapon> weapons = _context.Weapons.ToList();
            return weapons;
        }
        public bool RemoveById(int weaponId)
        {
            var weapon = GetWeaponById(weaponId);
            if (weapon == default(Weapon)) 
            {
                return false;
            }
            _context.Remove(weapon);
            return _context.SaveChanges() != 0;
        }
        public List<Weapon> GetWeapons(string searchStringCategoryName, string searchStringBrandName) 
        {
            List<Weapon> weapons = _context.Weapons.ToList();
            if (!String.IsNullOrEmpty(searchStringCategoryName) && !String.IsNullOrEmpty(searchStringBrandName))
            {
                weapons = weapons.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())
                && x.Brand.BrandName.ToLower().Contains(searchStringBrandName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringCategoryName))
            {
                weapons = weapons.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringBrandName))
            {
                weapons = weapons.Where(x => x.Brand.BrandName.ToLower().Contains(searchStringBrandName.ToLower())).ToList();
            }
            return weapons;
        }
        public bool Update(int weaponId, string name, int brandId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount) 
        {
            var weapon = GetWeaponById(weaponId);
            if (weapon == default(Weapon))
            {
                return false;
            }
            weapon.WeaponName = name;
            weapon.Brand = _context.Brands.Find(brandId);
            weapon.Category = _context.Categories.Find(categoryId);
            weapon.Picture = picture;
            weapon.Quantity = quantity;
            weapon.Description = description;
            weapon.Price = price;
            weapon.Discount = discount;
            _context.Update(weapon);
            return _context.SaveChanges() != 0;
        }
    }
}
