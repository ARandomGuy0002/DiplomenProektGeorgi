﻿using SwordParadise.Abstraction;
using SwordParadise.Data;
using SwordParadise.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SwordParadise.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<Weapon> GetWeaponsByCategory(int categoryId)
        {
            return _context.Weapons
                .Where(x => x.CategoryId == categoryId)
                .ToList();
        }
    }
}
