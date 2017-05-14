using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Accounts receivable model.
    /// </summary>
    public class AccountsReceivable
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

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
        /// The discount price.
        /// </summary>
        public float Discount { get; set; }

        /// <summary>
        /// The addition price.
        /// </summary>
        public int Addition { get; set; }

        /// <summary>
        /// Define if the account were payed.
        /// </summary>
        public float Payed { get; set; }

        /// <summary>
        /// Price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// A account is liquidated of the value payed is equal to the price.
        /// </summary>
        public bool Liquidated
        {
            get
            {
                return Payed == Price;
            }
        }

        /// <summary>
        /// Customer unique identifier, in the case of a natrual person for example it will
        /// be a CPF.
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email information.
        /// </summary>
        public string UserEmail { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        public string UserPhone { get; set; }
    }
}
