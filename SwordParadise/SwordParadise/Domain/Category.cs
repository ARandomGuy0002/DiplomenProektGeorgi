using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwordParadise.Domain
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
