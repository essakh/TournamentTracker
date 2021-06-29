﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Holds the unique name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Holds the fee for each team (or person?) to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Holds the teams that are entered to participate in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Holds the prizes that can be won to different place holders at the end of the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Holds all matchups for each round.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>(); //Rounds(PairOfMatchUpsAsList())


    }
}
