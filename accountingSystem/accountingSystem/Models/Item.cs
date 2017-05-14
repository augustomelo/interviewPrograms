using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Item model.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Item unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price.
        /// </summary>
        public float Price { get; set; }
    }
}
