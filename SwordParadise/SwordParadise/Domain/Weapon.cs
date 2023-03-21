﻿using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SwordParadise.Domain
{
    public class Weapon
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string WeaponName { get; set; }
        [Required]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Picture { get; set; }
        [Required]
        [Range(0, 5000)]
        public int Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, 3000)]
        public decimal Price { get; set; }
        [Range(0, 100)]
        public decimal Discount { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}