using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Accounts receivable model.
    /// </summary>
    public class AccountsReceivable : AccountsBase
    {
        /// <summary>
        /// Emission date.
        /// </summary>
        public DateTime Emission { get; set; }

        /// <summary>
        /// Due date of the account receivable, when you will
        /// receive the value.
        /// </summary>
        public DateTime Due { get; set; }

        /// <summary>
        /// User that is related to the account receivable
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The discount in percentage.
        /// </summary>
        public float Discount { get; set; }

        /// <summary>
        /// The addition in percentage.
        /// </summary>
        public int MyProperty { get; set; }
    }
}
