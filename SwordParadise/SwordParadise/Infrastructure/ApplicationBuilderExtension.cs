using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SwordParadise.Data;
using SwordParadise.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwordParadise.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app) 
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            await RoleSeeder(services);
            await SeedAdministrator(services);

            var dataCategory = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedCategories(dataCategory);

            var dataBrand = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedBrands(dataBrand);
            return app;
        }
        private static async Task RoleSeeder(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = {"Administrator", "Client"};  
            
            IdentityResult roleResult;

            foreach (var role in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);

                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        private static async Task SeedAdministrator(IServiceProvider serviceProvider) 
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            if (await userManager.FindByNameAsync("admin") == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.FirstName = "admin";
                user.LastName = "admin";
                user.Address = "admin";
                user.Email = "admin@abv.bg";
                user.UserName = "admin";

                var result = await userManager.CreateAsync(user, "Admin1234");
                if (result.Succeeded) 
                { 
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }

            }
        }
        private static void SeedCategories(ApplicationDbContext dataCategory) 
        {
            if (dataCategory.Categories.Any())
            {
                return;
            }
            dataCategory.Categories.AddRange(new[]
            {
                new Category {CategoryName="Sword"},
                new Category {CategoryName="Pistol"},
                new Category {CategoryName="Revolver"},
                new Category {CategoryName="Crossbow"},
                new Category {CategoryName="Ammunition"},
                new Category {CategoryName="Accessories"}
            });
            dataCategory.SaveChanges();
        }
        private static void SeedBrands(ApplicationDbContext dataBrand) 
        {
            if (dataBrand.Brands.Any())
            {
                return;
            }
            dataBrand.Brands.AddRange(new[]
            {
                new Brand {BrandName="Benelli"},
                new Brand {BrandName="Blaser"},
                new Brand {BrandName="Fabarm"},
                new Brand {BrandName="Glock"},
                new Brand {BrandName="Sako"}
            });
            dataBrand.SaveChanges();
        }
    }
}
