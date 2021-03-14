using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TracerLibrary
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } 
        public List<PrizeModel> Prizes { get; set; } 
        public List<List<MatchupModel>> Rounds { get; set; }

    }
}
