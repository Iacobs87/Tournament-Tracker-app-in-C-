using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {

        /// <summary>
        /// The unique identifier for a Matchup entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the team
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The unique identifier for the parent matchup (team).
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represent the matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
