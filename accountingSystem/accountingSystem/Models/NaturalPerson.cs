using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accountingSystem.Models
{
    /// <summary>
    /// Customer model that holds the customer information.
    /// </summary>
    public class NaturalPerson : User
    {
        /// <summary>
        /// CPF: Cadastro de pessoa fisica
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Natural person address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Contact information.
        /// </summary>
        public Contact ContactInfo { get; set; }
    }
}
