using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Purchase model.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// Purchase unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Item that was purchased.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// Quantity of items that were celled.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        public float TotalAmount
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }
}
