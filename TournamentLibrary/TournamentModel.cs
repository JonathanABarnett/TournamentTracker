using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents what a tournament is made of.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the current tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the amount each person is required to pay to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of all the teams entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of all the prizes for the current tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the list of rounds that each tournament contains.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
