using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Julio_C_301016383.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Julio_C_301016383.Controllers
{    
    public class TournamentController : Controller
    {
        private ITournamentRepository tournamentsRepo;
        private IClubRepository clubsRepo;

        public TournamentController(ITournamentRepository tournamentsRepository, IClubRepository clubsRepository)
        {
            tournamentsRepo = tournamentsRepository;
            clubsRepo = clubsRepository;
        }

        public IActionResult Index() //ex-TournamentPage()
        {
            return View("Index", tournamentsRepo.Tournaments);
        }

        [Authorize(Roles = "Admins")]
        public ViewResult AddTournament()
        {
            // check admin or not
            return View("AddTournament", new Tournament());
        }

        [HttpPost]
        [Authorize(Roles = "Admins")]
        public IActionResult AddTournament(Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                int minDurationDates = Convert.ToInt32((tournament.To.Date - tournament.From.Date).TotalDays + 1);
                int minSchedule = minDurationDates * 4;

                if (clubsRepo.Clubs.Count() < tournament.ClubCount)
                {
                    TempData["validation"] = $"Club Count ({tournament.ClubCount}) is larger than exsiting Club List Count({clubsRepo.Clubs.Count()})";
                    return RedirectToAction("AddTournament");
                }
                else if (minSchedule < 0)
                {
                    TempData["validation"] = "Duration is invalid";
                    return RedirectToAction("AddTournament");
                }
                else if (tournament.ClubCount > minSchedule)
                {
                    TempData["validation"] = $"Duration should be longer than " + minDurationDates;
                    return RedirectToAction("AddTournament");
                }
                else
                {
                    tournamentsRepo.CreateTournament(tournament);
                    TempData["message"] = $"{tournament.Name} has been saved";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View(tournament);
            }
        }

        [HttpGet]
        public ViewResult TournamentDetails(int tournamentID)
        {
            Tournament tournament = tournamentsRepo.Tournaments.Where(t => t.TournamentID == tournamentID).FirstOrDefault();
            Club winnerClub = tournamentsRepo.GetFinalWinner(tournamentID);
            if (winnerClub != null)
            {
                ViewBag.winnerID = winnerClub.ClubID;
                ViewBag.winnerName = winnerClub.Name;
            }

            return View("TournamentDetails", tournament);
        }

        [Authorize(Roles = "GeneralUsers")]

        public IActionResult CreateMatches(int tournamentID)
        {
            Tournament tournament = tournamentsRepo.Tournaments.Where(t => t.TournamentID == tournamentID).FirstOrDefault();
            // when all current matches not finished, dont create again!
            // when all current matches finished, create new matches using winners

            // randomly selected clubs
            List<Club> selectedClubList = new List<Club>();
            Random random = new Random();
            int number;
            int[] randomClubID = null;

            // first match
            if (tournament.Matches.Count() == 0)
            {

                // Random integer between 0 and max(max not included):
                randomClubID = new int[tournament.ClubCount];

                for (int i = 0; i < tournament.ClubCount; i++)
                {
                    number = random.Next(0, clubsRepo.Clubs.Count() + 1);
                    if (!randomClubID.Contains(number)) //If it's not contains, add number to array;
                        randomClubID[i] = number;
                    else //If it contains, restart random process
                        i--;
                }

                for (int i = 0; i < randomClubID.Count(); i++)
                {
                    selectedClubList.AddRange(clubsRepo.Clubs.Where(c => c.ClubID == randomClubID[i]));
                }

                tournamentsRepo.CreateMatches(tournament, selectedClubList);
            }
            // After first match
            else
            {
                // Check all current matches finished
                bool isAllFinished = true;
                foreach (Match m in tournament.Matches)
                {
                    if (!m.IsFinished)
                        isAllFinished = false;
                }

                // If all matches finished, create next round using just winner clubs & drew club
                if (isAllFinished)
                {
                    // **** check final winner
                    Match finalMatch = new Match();
                    bool isFinal = false;

                    // just select from last round
                    string roundName = tournament.Matches.LastOrDefault().Name;

                    List<int> winnerClubs = new List<int>();
                    foreach (Match m in tournament.Matches.Where(m => m.Name == roundName))
                    {
                        // Final winner
                        if (m.Name == "Round of 1" && m.ClubID2 == 0)
                        {
                            finalMatch = m;
                            isFinal = true;
                        }

                        if (!isFinal)
                        {
                            if (m.ClubID2 == 0) // include first drew a bye club
                            {
                                winnerClubs.Add(m.ClubID1);

                            }
                            else
                            {
                                if (m.Club1Score > m.Club2Score)
                                {
                                    winnerClubs.Add(m.ClubID1);
                                }
                                else if (m.Club1Score == m.Club2Score) // drew a bye clubs
                                {
                                    winnerClubs.Add(m.ClubID1);
                                    winnerClubs.Add(m.ClubID2);
                                }
                                else
                                {
                                    winnerClubs.Add(m.ClubID2);
                                }
                            }
                        }
                    }

                    if (!isFinal)
                    {
                        // randomly select clubs in winner clubs
                        randomClubID = new int[winnerClubs.Count];

                        for (int i = 0; i < winnerClubs.Count; i++)
                        {
                            int randomIndex = random.Next(0, winnerClubs.Count());
                            if (!randomClubID.Contains(winnerClubs[randomIndex])) //If it's not contains, add number to array;
                                randomClubID[i] = winnerClubs[randomIndex];
                            else //If it contains, restart random process
                                i--;
                        }

                        // ********************** until just 1 winner....

                        for (int i = 0; i < randomClubID.Count(); i++)
                        {
                            selectedClubList.AddRange(clubsRepo.Clubs.Where(c => c.ClubID == randomClubID[i]));
                        }

                        tournamentsRepo.CreateMatches(tournament, selectedClubList);

                        if (selectedClubList.Count == 1)
                        {
                            return RedirectToAction("TournamentDetails", new { tournamentID = tournament.TournamentID });
                        }
                    }
                    else
                    {
                        TempData["validation"] = "Final!!";
                    }
                }
                else // all matches not finished
                {
                    TempData["validation"] = "Matches are not finished";
                }
            }

            return View("TournamentDetails", tournament);
        }

        public IActionResult AddGoal(int matchID)
        {
            Match match = tournamentsRepo.Matches.Where(m => m.MatchID == matchID).FirstOrDefault();
            Tournament tournament = tournamentsRepo.Tournaments.Where(t => t.TournamentID == match.TournamentID).FirstOrDefault();

            if (!match.IsFinished)
            {
                ViewBag.TournamentID = tournament.TournamentID;

                // Club1
                ViewBag.ClubID1 = match.ClubID1;
                ViewBag.ClubName1 = clubsRepo.Clubs.Where(c => c.ClubID == match.ClubID1).FirstOrDefault().Name;
                List<Player> playerList1 = new List<Player>();
                playerList1.AddRange(clubsRepo.clubPlayers(match.ClubID1));
                ViewBag.ListOfPlayers1 = playerList1;

                // Club2
                ViewBag.ClubID2 = match.ClubID2;
                ViewBag.ClubName2 = clubsRepo.Clubs.Where(c => c.ClubID == match.ClubID2).FirstOrDefault().Name;
                List<Player> playerList2 = new List<Player>();
                playerList2.AddRange(clubsRepo.clubPlayers(match.ClubID2));
                ViewBag.ListOfPlayers2 = playerList2;

                Goal goal = new Goal();
                goal.MatchID = matchID;

                return View("AddGoal", goal);
            }
            else
            {
                TempData["validation"] = "This match have already finished";

                return RedirectToAction("TournamentDetails", new { tournamentID = tournament.TournamentID });
            }
        }

        [HttpPost]
        public IActionResult AddGoal(Goal goal, int PlayerID1, int PlayerID2)
        {
            Match match = tournamentsRepo.Matches.Where(m => m.MatchID == goal.MatchID).FirstOrDefault();
            Tournament tournament = tournamentsRepo.Tournaments.Where(t => t.TournamentID == match.TournamentID).FirstOrDefault();
            int playerID = PlayerID1 == 0 ? PlayerID2 : PlayerID1;
            goal.PlayerID = playerID;
            Player player = clubsRepo.GetPlayer(playerID);

            bool fakeModelStatus = true;
            if ((goal.ClubID == null) || (PlayerID1 == 0 && PlayerID2 == 0) || goal.GoalTime == null)
            {
                TempData["validation"] = "Please enter all information";
                fakeModelStatus = false;
            }
            else if (PlayerID1 != 0 && PlayerID2 != 0)
            {
                TempData["validation"] = "Please select just 1 player";
                fakeModelStatus = false;
            }
            else if (player.ClubID != goal.ClubID)
            {
                TempData["validation"] = "Please choose a player who belong to the selected club ";
                fakeModelStatus = false;
            }


            if (fakeModelStatus)
            {
                // Add Goal
                tournamentsRepo.AddGoal(goal);

                return View("TournamentDetails", tournament);
            }
            else
            {
                return RedirectToAction("AddGoal", new { matchID = goal.MatchID });
            }
        }

        public IActionResult FinishMatch(int matchID, int tID)
        {
            tournamentsRepo.FinishMatch(matchID);

            return RedirectToAction("TournamentDetails", new { tournamentID = tID });
        }
    }
}
