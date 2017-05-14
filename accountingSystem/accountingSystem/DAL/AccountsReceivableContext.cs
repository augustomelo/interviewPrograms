using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using accountingSystem.Models;

namespace accountingSystem.DAL
{
    /// <summary>
    /// Account data accesss layer.
    /// </summary>
    public class AccountsReceivableContext : DbContext
    {
        #region Properties
        /// <summary>
        /// Acoounts receivable data set.
        /// </summary>
        public DbSet<AccountsReceivable> AccountsReceivable { get; set; }
        #endregion Properties


        #region Constructor
        /// <summary>
        /// Class constructor
        /// </summary>
        public AccountsReceivableContext(DbContextOptions<AccountsReceivableContext> options) : base(options)
        {

        }
        #endregion Constructor
    }
}
