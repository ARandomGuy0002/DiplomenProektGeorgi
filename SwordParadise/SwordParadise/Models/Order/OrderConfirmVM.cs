﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SwordParadise.Models.Order
{
    public class OrderConfirmVM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string User { get; set; }
        [Required]
        public int WeaponId { get; set; }
        public string WeaponName { get; set; }
        public string Picture { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
