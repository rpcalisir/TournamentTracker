using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntry
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public Team TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>
        public Matchup ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>
        public MatchupEntry(double initialScore)
        {
            Console.WriteLine();
        }
    }
}
