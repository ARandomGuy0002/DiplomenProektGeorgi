﻿using System.ComponentModel.DataAnnotations;

namespace SwordParadise.Models.Brand
{
    public class BrandPairVM
    {
        public int Id { get; set; }
        [Display(Name = "Brand")]
        public string Name { get; set; }
    }
}
