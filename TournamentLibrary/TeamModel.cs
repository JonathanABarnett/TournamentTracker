using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents what a team consists of.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of people on the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
