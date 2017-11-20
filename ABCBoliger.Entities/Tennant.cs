using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBoliger.Entities
{
    /// <summary>
    /// Represents a tennant
    /// </summary>
    public class Tennant
    {
        /// <summary>
        /// Initializes a new instance of the tennant class
        /// </summary>
        /// <param name="firstName">The first name of the tennant</param>
        /// <param name="lastName">The last name of the tennant</param>
        /// <param name="apartment">The apartment the tennant is renting, if any. Can be null</param>
        public Tennant(string firstName, string lastName, Apartment apartment)
        {
            FirstName = firstName;
            LastName = lastName;
            Apartment = apartment;
        }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the apartment
        /// </summary>
        public Apartment Apartment { get; set; }
    }
}
