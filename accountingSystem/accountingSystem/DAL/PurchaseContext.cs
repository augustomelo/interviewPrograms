using accountingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.DAL
{
    /// <summary>
    /// Purshase data access layer
    /// </summary>
    public class PurchaseContext: DbContext
    {
        #region Properties
        /// <summary>
        /// Purchase data.
        /// </summary>
        public DbSet<Purchase> Purchase { get; set; }
        #endregion Properties


        #region Constructor
        /// <summary>
        /// Class constructor.
        /// </summary>
        private PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        {

        }
        #endregion Constructor
    }
}
