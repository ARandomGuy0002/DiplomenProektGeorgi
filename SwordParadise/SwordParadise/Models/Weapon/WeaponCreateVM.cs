using SwordParadise.Models.Brand;
using SwordParadise.Domain;
using SwordParadise.Models.Category;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SwordParadise.Models.Weapon
{
    public class WeaponCreateVM
    {
        public WeaponCreateVM() 
        {
            Brands = new List<BrandPairVM>();
            Categories = new List<CategoryPairVM>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Weapon Name")]
        public string WeaponName { get; set; }
        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public virtual List<BrandPairVM> Brands { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual List<CategoryPairVM> Categories { get; set; }
        [Display(Name = "Picture")]
        public string Picture { get; set; }
        [Required]
        [Range(0, 5000)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Discount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Discount { get; set; }
    }
}
