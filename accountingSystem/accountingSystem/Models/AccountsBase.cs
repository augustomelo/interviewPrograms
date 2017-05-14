using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Account base class.
    /// </summary>
    public abstract class AccountsBase
    {
        /// <summary>
        /// Accounts unique identifier.
        /// </summary>
        public int ID { get; set; }
    }
}
