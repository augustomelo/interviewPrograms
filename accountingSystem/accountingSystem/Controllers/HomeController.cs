using accountingSystem.DAL;
using accountingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace accountingSystem.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Acccounts receivable controller.
        /// </summary>
        private readonly AccountsReceivableContext _context;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="context">Context.</param>
        public HomeController(AccountsReceivableContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Entry point of the Home view. It will set on the view data the amount of accounts
        /// receivable active and the list of all accounts.
        /// </summary>
        /// <param name="description">Description parameter.</param>
        /// <returns>Home view</returns>
        public IActionResult Index(string description)
        {
            ViewData["AccReceiv"] = _context.AccountsReceivable.ToList();
            ViewData["ActiveAcc"] = _context.AccountsReceivable.Where(entry => entry.Liquidated).Count();

            if (!string.IsNullOrEmpty(description))
            {
                ViewData["AccReceiv"] = _context.AccountsReceivable
                    .Where(entry => entry.Description.ToLower().Contains(description.ToLower()))
                    .ToList();
            }

            return View();
        }

        /// <summary>
        /// Get the active accounts receivable.
        /// </summary>
        /// <returns>The accounts receivable.</returns>
        public int GetActiveAccounts()
        {
            var data = _context.AccountsReceivable;

            return data.Where(entry => entry.Liquidated).Count();
        }

        /// <summary>
        /// Get a account receivable by id.
        /// </summary>
        /// <param name="id">Account receivable.</param>
        /// <returns>The account receivable.</returns>
        [HttpPost]
        public IActionResult GetAccountable([FromBody] int id)
        {
            var data = _context.AccountsReceivable;

            return Json(data.FirstOrDefault(entry => entry.ID == id));
        }

        /// <summary>
        /// Persist a account receivable into the dabatase.
        /// </summary>
        /// <param name="accountsReceivable">Account receivable.</param>
        /// <returns>A redirection to the index action.</returns>
        [HttpPost]
        public ActionResult Persist(AccountsReceivable accountsReceivable)
        {
            if (accountsReceivable.ID > 0)
            {
                _context.Entry(accountsReceivable).State = EntityState.Modified;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            _context.Add(accountsReceivable);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Liquidate a account receivable.
        /// </summary>
        /// <param name="id">Account unique identifier.</param>
        /// <returns>A redirection to the index action.</returns>
        public ActionResult Liquidate(int id)
        {
            var data = _context.AccountsReceivable.FirstOrDefault(entry => entry.ID == id);
            data.Payed = data.Price;

            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
