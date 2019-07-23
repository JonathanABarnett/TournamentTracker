using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents a matchup.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of participating entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the current round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
