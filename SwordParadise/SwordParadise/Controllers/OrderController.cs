using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwordParadise.Data;
using SwordParadise.Domain;
using SwordParadise.Models.Order;
using System.Collections.Generic;
using System;
using System.Data;
using System.Globalization;
using System.Security.Claims;
using System.Linq;

namespace SwordParadise.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            this._context = context;
        }
        // GET: OrderController

        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            List<OrderIndexVM> orders = _context.Orders.Select(x => new OrderIndexVM
            {
                Id = x.Id,
                OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                UserId = x.UserId,
                User = x.User.UserName,
                WeaponId = x.WeaponId,
                Weapon = x.Weapon.WeaponName,
                Picture = x.Weapon.Picture,
                Quantity = x.Quantity,
                Description = x.Weapon.Description,
                Price = x.Price,
                Discount = x.Discount,
                TotalPrice = x.TotalPrice,
            }).ToList();
            return View(orders);
        }
        [AllowAnonymous]
        public IActionResult MyOrders(string searchString)
        {
            string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == currentUserId);
            if (user == null)
            {
                return null;
            }
            List<OrderIndexVM> orders = _context.Orders.Where(x => x.UserId == user.Id).Select(x => new OrderIndexVM
            {
                Id = x.Id,
                OrderDate = x.OrderDate.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                UserId = x.UserId,
                User = x.User.UserName,
                WeaponId = x.WeaponId,
                Weapon = x.Weapon.WeaponName,
                Picture = x.Weapon.Picture,
                Quantity = x.Quantity,
                Description = x.Weapon.Description,
                Price = x.Price,
                Discount = x.Discount,
                TotalPrice = x.TotalPrice,
            }).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.Weapon.ToLower().Contains(searchString.ToLower())).ToList();
            }
            return this.View(orders);

        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        [AllowAnonymous]
        public ActionResult Create(int weaponId, int quantity)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var weapon = this._context.Weapons.SingleOrDefault(x => x.Id == weaponId);

            if (user == null || weapon == null || weapon.Quantity < quantity)
            {
                return this.RedirectToAction("Index", "Weapon");
            }
            OrderConfirmVM orderForDb = new OrderConfirmVM
            {
                UserId = userId,
                User = user.UserName,
                WeaponId = weaponId,
                WeaponName = weapon.WeaponName,
                Picture = weapon.Picture,
                Quantity = quantity,
                Description= weapon.Description,
                Price = weapon.Price,
                Discount = weapon.Discount,
                TotalPrice = quantity * weapon.Price - quantity * weapon.Price * weapon.Discount / 100
            };
            return View(orderForDb);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Create(OrderConfirmVM bindingModel)
        {
            if (ModelState.IsValid)
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _context.Users.SingleOrDefault(u => u.Id == userId);
                var weapon = this._context.Weapons.SingleOrDefault(x => x.Id == bindingModel.WeaponId);

                if (user == null || weapon == null || weapon.Quantity < bindingModel.Quantity || bindingModel.Quantity == 0)
                {
                    return this.RedirectToAction("Index", "Weapon");
                }
                Order orderForDb = new Order
                {
                    OrderDate = DateTime.UtcNow,
                    WeaponId = bindingModel.WeaponId,
                    UserId = userId,
                    Quantity = bindingModel.Quantity,
                    Price = weapon.Price,
                    Discount = weapon.Discount,
                };
                weapon.Quantity -= bindingModel.Quantity;
                this._context.Weapons.Update(weapon);
                this._context.Orders.Add(orderForDb);
                this._context.SaveChanges();
            }
            return this.RedirectToAction("Index", "Weapon");
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
