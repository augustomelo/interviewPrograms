using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Address information.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Address unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Street name.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Neighborhood
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// Number of the building.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Additional information like:
        /// - Room number
        /// - Building
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// ZIP code.
        /// </summary>
        public string ZipCode { get; set; }
    }
}
