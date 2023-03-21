using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwordParadise.Domain
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int WeaponId { get; set; }
        public virtual Weapon Weapon { get; set; }
        [Required] 
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Range(0, 3000)]
        public decimal Price { get; set; }
        [Range(0, 100)]
        public decimal Discount { get; set; }
        public decimal TotalPrice 
        {
            get
            {
                return Quantity * Price - Quantity * Price * Discount / 100;
            }
        }
    }
}
