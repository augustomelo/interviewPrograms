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
                return Quantity * Price;
            }
        }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Define if the purschase was cancelled.
        /// </summary>
        public bool Cancelled { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        public string ItemName { get; set; }
    }
}
