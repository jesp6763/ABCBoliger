using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBoliger.Entities
{
    /// <summary>
    /// Represents an apartment
    /// </summary>
    public class Apartment
    {
        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// Gets or sets the area size in square meters
        /// </summary>
        public decimal AreaSize { get; set; }
        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }
    }
}
