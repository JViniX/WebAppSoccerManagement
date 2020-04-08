using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public interface ITournamentRepository
    {
        IEnumerable<Tournament> Tournaments { get; }

        void CreateTournament(Tournament tournament);

        void CreateMatches(Tournament tournament, List<Club> clubs);

        IEnumerable<Match> tournamentMatches(int TournamentID);

        IEnumerable<Match> Matches { get; }

        IEnumerable<Goal> Goals { get; }

        void AddGoal(Goal goal);
        IEnumerable<Goal> matchGoals(int matchID);

        void UpdateMatchScore(int matchID, int? clubID);
        void FinishMatch(int matchID);

        Club GetFinalWinner(int tournamentID);

        List<int?> GetTop3ClubIDs();
    }
}
