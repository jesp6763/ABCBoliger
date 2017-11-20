using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBoliger.Entities
{
    /// <summary>
    /// Represents an address
    /// </summary>
    public struct Address
    {
        /// <summary>
        /// Initializes a new instance of the Address struct
        /// </summary>
        /// <param name="city">The name of the city</param>
        /// <param name="streetName">The street name</param>
        /// <param name="postalCode">The postal code</param>
        public Address(string city, string streetName, string postalCode)
        {
            City = city;
            StreetName = streetName;
            PostalCode = postalCode;
        }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the street name
        /// </summary>
        public string StreetName { get; set; }
    }
}
