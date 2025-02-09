﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        ///     Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of TeamCompeting
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the previous Matchup this team engaged in - updated with each win.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
