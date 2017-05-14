using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Contact information like:
    /// - Email
    /// - Mobile phone
    /// - Phone
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Contact unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Email information.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Mobile phone number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        public string Phone { get; set; }
    }
}
