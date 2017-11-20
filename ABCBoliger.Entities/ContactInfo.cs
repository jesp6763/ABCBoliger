using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBoliger.Entities
{
    /// <summary>
    /// Contact information
    /// </summary>
    public struct ContactInfo
    {
        /// <summary>
        /// Initializes a new instance of the ContactInfo struct
        /// </summary>
        /// <param name="phoneNumber">The phone number</param>
        public ContactInfo(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
