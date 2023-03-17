using SwordParadise.Abstraction;
using SwordParadise.Data;
using SwordParadise.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SwordParadise.Services
{
    public class BrandService : IBrandService
    {
        private readonly ApplicationDbContext _context;

        public BrandService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public Brand GetBrandById(int brandId) 
        {
            return _context.Brands.Find(brandId);
        }
        public List<Brand> GetBrands() 
        { 
            List<Brand> brands = _context.Brands.ToList();
            return brands;
        }
        public List<Weapon> GetWeaponsByBrand(int brandId) 
        {
            return _context.Weapons
                .Where(x => x.BrandId == brandId)
                .ToList();
        }
    }
}
