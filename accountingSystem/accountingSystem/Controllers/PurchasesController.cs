using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using accountingSystem.DAL;
using accountingSystem.Models;

namespace accountingSystem.Controllers
{
    /// <summary>
    /// Purchases controller
    /// </summary>
    public class PurchasesController : Controller
    {
        /// <summary>
        /// Purchases context.
        /// </summary>
        private readonly PurchaseContext _context;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="context"></param>
        public PurchasesController(PurchaseContext context)
        {
            _context = context;    
        }

        /// <summary>
        /// Entry point of the Purchase view. It will set on the view data the list
        /// of purchases.
        /// </summary>
        /// <param name="purchaseName">Purchase name.</param>
        /// <returns></returns>
        public IActionResult Index(string purchaseName)
        {
            ViewData["Purchases"] = _context.Purchase.ToList();

            if (!string.IsNullOrEmpty(purchaseName))
            {
                ViewData["Purchases"] = _context.Purchase
                    .Where(entry => entry.Name.ToLower().Contains(purchaseName.ToLower()))
                    .ToList();
            }

            return View();
        }

        /// <summary>
        /// Get a purchase by id.
        /// </summary>
        /// <param name="id">Purchase.</param>
        /// <returns>The purchase.</returns>
        [HttpPost]
        public IActionResult GerPurchase([FromBody] int id)
        {
            var data = _context.Purchase;

            return Json(data.FirstOrDefault(entry => entry.ID == id));
        }

        /// <summary>
        /// Persist a purchase into the dabatase.
        /// </summary>
        /// <param name="purchase">Purchase.</param>
        /// <returns>A redirection to the index action.</returns>
        [HttpPost]
        public ActionResult Persist(Purchase purchase)
        {
            if (purchase.ID > 0)
            {
                _context.Entry(purchase).State = EntityState.Modified;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            _context.Add(purchase);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Cancell a purchase.
        /// </summary>
        /// <param name="id">Purchase identifier.</param>
        /// <returns>A redirection to the index action.</returns>
        public ActionResult Cancell(int id)
        {
            var data = _context.Purchase.FirstOrDefault(entry => entry.ID == id);
            data.Cancelled = true;

            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
