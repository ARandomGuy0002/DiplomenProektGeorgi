﻿using SwordParadise.Domain;
using System.Collections.Generic;

namespace SwordParadise.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoryById(int categoryId);
        List<Product> GetProductsByCategory(int categoryId);
    }
}