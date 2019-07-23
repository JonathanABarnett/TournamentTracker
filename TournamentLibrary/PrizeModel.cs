using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents a prize for the tournament winner.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the prize place.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount the prize is worth.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of total winnings.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
