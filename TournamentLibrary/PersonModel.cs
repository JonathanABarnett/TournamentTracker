using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents a person to enter the tournament.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the phonenumber.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
