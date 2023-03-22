﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SwordParadise.Models.Statistics
{
    public class StatisticsVM
    {
        [Display(Name = "Count Clients")]
        public int CountClients { get; set; }
        [Display(Name = "Count Weapons")]
        public int CountWeapons { get; set; }
        [Display(Name = "Count Orders")]
        public int CountOrders { get; set; }
        [Display(Name = "Total Sum Orders")]
        public decimal SumOrders { get; set; }
    }
}
