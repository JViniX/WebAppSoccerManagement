using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Julio_C_301016383.Models
{
    public class IMatchRepository
    {
        private ApplicationDbContext context;

        public IMatchRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Match> GetListOfMatches()
        {
            return context.Matches; //.Include(c => c.Players);
        }


        public void SaveMatch(Match match)
        {
            if (match.MatchID == 0)
            {
                context.Matches.Add(match);
            }
            else
            {
                Match dbEntry = context.Matches
                    .FirstOrDefault(m => m.MatchID == match.MatchID);
                if (dbEntry != null)
                {
                    dbEntry.Stadium = match.Stadium;
                    dbEntry.MatchDateAndTime = match.MatchDateAndTime;
                    dbEntry.Price = match.Price;
                    dbEntry.ClubID1 = match.ClubID1;
                    dbEntry.ClubID2 = match.ClubID2;
                }
            }
            context.SaveChanges();
        }

        public Match DeleteClub(int matchID)
        {
            Match dbEntry = context.Matches.FirstOrDefault(m => m.MatchID == matchID);
            if (dbEntry != null)
            {
                context.Matches.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
