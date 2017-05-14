using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    public abstract class User
    {
        /// <summary>
        /// Customer unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        public string Name { get; set; }
    }
}
