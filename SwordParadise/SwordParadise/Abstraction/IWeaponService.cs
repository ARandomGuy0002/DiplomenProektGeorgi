using SwordParadise.Domain;
using System.Collections.Generic;

namespace SwordParadise.Abstraction
{
    public interface IWeaponService
    {
        bool Create(string name, int brandId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount);
        bool Update(int weaponId, string name, int brandId, int categoryId, string picture, int quantity, string description, decimal price, decimal discount);
        List<Weapon> GetWeapons();
        Weapon GetWeaponById(int weaponId);
        bool RemoveById(int weaponId);
        List<Weapon> GetWeapons(string searchStringCategoryName, string searchStringBrandName, string searchStringWeaponName);
    }
}
