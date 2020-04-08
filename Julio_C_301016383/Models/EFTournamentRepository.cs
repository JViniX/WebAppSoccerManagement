using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public class EFTournamentRepository : ITournamentRepository
    {
        private ApplicationDbContext context;


        public EFTournamentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Tournament> Tournaments => context.Tournaments.Include(t => t.Matches);
        public IEnumerable<Match> Matches => context.Matches.Include(m => m.Goals);

        public IEnumerable<Goal> Goals => context.Goals;
        public IEnumerable<Club> Clubs => context.Clubs;


        public void CreateTournament(Tournament tournament)
        {
            // there will be no editing for tournament
            context.Tournaments.Add(tournament);

            context.SaveChanges();
        }

        public void CreateMatches(Tournament tournament, List<Club> selectedClubs)
        {
            // create matches
            int duration = Convert.ToInt32((tournament.To.Date - tournament.From.Date).TotalDays) + 1;
            TimeSpan[] schedule = { new TimeSpan(13, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(17, 0, 0), new TimeSpan(19, 0, 0) };
            int durationCount = 0;
            int countSchedule = 0;

            // selectClubs[11] >> 0 ... 10 (11count)
            // if tournament.ClubCount 11 
            // i 0(0,1), 2(2,3), 4(4,5), ..., 10(10,11),
            for (int i = 0; i < selectedClubs.Count; i += 2)
            {
                Match match = new Match();
                match.TournamentID = tournament.TournamentID;
                //List<Club> clubs = new List<Club>();
                //clubs.Add(selectedClubs[i]);
                //clubs.Add(selectedClubs[i+1]);
                //match.ClubList = clubs;
                match.ClubID1 = selectedClubs[i].ClubID;
                match.Club1Name = selectedClubs[i].Name;

                match.IsFinished = true; // Drew a bye -> game finished
                if (i + 1 < selectedClubs.Count)
                {
                    match.IsFinished = false;
                    match.ClubID2 = selectedClubs[i + 1].ClubID;
                    match.Club2Name = selectedClubs[i + 1].Name;
                }

                match.Name = "Round of " + selectedClubs.Count();

                // change time
                if (countSchedule == schedule.Count())
                {
                    countSchedule = 0;
                    durationCount++;
                }

                // set date & time
                match.MatchDateAndTime = tournament.From.AddDays(durationCount);
                match.MatchDateAndTime = match.MatchDateAndTime.Add(schedule[countSchedule]);

                countSchedule++;

                match.Price = tournament.Price;

                SaveMatch(match);
            }
        }

        public void SaveMatch(Match match)
        {
            // there will be no editing for match

            // Randomly set stadium
            string[] stadiuns = new string[] { "Maracana", "Pacaembu", "Rogers Center", "Batistao", "Mineirao", "Barradao", "Olimpico" };
            Random r = new Random();
            int i = r.Next(stadiuns.Length);
            //Console.WriteLine(chars[i]);
            match.Stadium = stadiuns[i].ToString();

            context.Matches.Add(match);

            context.SaveChanges();
        }
        public IEnumerable<Match> tournamentMatches(int tournamentID)
        {
            return context.Matches.Where(m => m.TournamentID == tournamentID);
        }

        public void AddGoal(Goal goal)
        {
            context.Goals.Add(goal);
            UpdateMatchScore(goal.MatchID, goal.ClubID);
            context.SaveChanges();
        }

        public IEnumerable<Goal> matchGoals(int matchID)
        {
            return context.Goals.Where(g => g.MatchID == matchID);
        }

        public void UpdateMatchScore(int matchID, int? clubID)
        {
            Match match = Matches.Where(m => m.MatchID == matchID).FirstOrDefault();
            if (match.ClubID1 == clubID)
            {
                match.Club1Score++;
            }
            else
            {
                match.Club2Score++;
            }
            context.SaveChanges();
        }

        public void FinishMatch(int matchID)
        {
            Match match = Matches.Where(m => m.MatchID == matchID).FirstOrDefault();
            match.IsFinished = true;
            context.SaveChanges();
        }

        public Club GetFinalWinner(int tournamentID)
        {
            Tournament tournament = Tournaments.Where(t => t.TournamentID == tournamentID).FirstOrDefault();
            Club club;
            int winnerClubID;
            if (tournament.Matches != null)
            {
                if (tournament.Matches.Where(m => m.Name == "Round of 1").FirstOrDefault() != null)
                {
                    winnerClubID = Tournaments.Where(t => t.TournamentID == tournamentID).FirstOrDefault()
                                .Matches.Where(m => m.Name == "Round of 1").FirstOrDefault().ClubID1;
                    club = Clubs.Where(c => c.ClubID == winnerClubID).FirstOrDefault();
                    return club;
                }
            }
            return null;
        }

        public List<int?> GetTop3ClubIDs()
        {
            /*
             * SELECT clubid, count(clubid)
             * from goals
             *  group by clubid
             *  
             */
            var query = Goals.GroupBy(g => g.ClubID)
                       .Select(gg => new { ClubID = gg.Key, count = gg.Count() }).Take(3);
            List<int?> clubID = query.Select(q => q.ClubID).ToList();

            Console.WriteLine(clubID);

            return clubID;
        }


    }
}
