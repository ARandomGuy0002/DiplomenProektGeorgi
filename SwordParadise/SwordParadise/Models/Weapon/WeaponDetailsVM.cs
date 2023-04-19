using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SwordParadise.Models.Weapon
{
    public class WeaponDetailsVM
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Weapon Name")]
        public string WeaponName { get; set; }
        public int BrandId { get; set; }
        [Display(Name = "Brand")]
        public string BrandName { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Display(Name = "Picture")]
        public string Picture { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Discount")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Discount { get; set; }
    }
}
