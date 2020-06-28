using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
     public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for a Matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that where involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The ID from the DB that will be used to identify up the winner
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Wich round this match is part of
        /// </summary>
        public int MatchRound { get; set; }

    }
}
