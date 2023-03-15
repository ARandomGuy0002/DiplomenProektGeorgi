using SwordParadise.Domain;
using System.Collections.Generic;

namespace SwordParadise.Abstraction
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int brandId);
        List<Product> GetProductsByBrand(int brandId);
    }
}
