using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwordParadise.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using SwordParadise.Models.Weapon;
using SwordParadise.Models.Order;
using SwordParadise.Models.Client;

namespace SwordParadise.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SwordParadise.Models.Weapon.WeaponCreateVM> WeaponCreateVM { get; set; }
        public DbSet<SwordParadise.Models.Weapon.WeaponIndexVM> WeaponIndexVM { get; set; }
        public DbSet<SwordParadise.Models.Weapon.WeaponEditVM> WeaponEditVM { get; set; }
        public DbSet<SwordParadise.Models.Weapon.WeaponDetailsVM> WeaponDetailsVM { get; set; }
        public DbSet<SwordParadise.Models.Weapon.WeaponDeleteVM> WeaponDeleteVM { get; set; }
        public DbSet<SwordParadise.Models.Order.OrderIndexVM> OrderIndexVM { get; set; }
        public DbSet<SwordParadise.Models.Order.OrderConfirmVM> OrderConfirmVM { get; set; }
        public DbSet<SwordParadise.Models.Client.ClientIndexVM> ClientIndexVM { get; set; }
        public DbSet<SwordParadise.Models.Client.ClientDeleteVM> ClientDeleteVM { get; set; }
    }
}
