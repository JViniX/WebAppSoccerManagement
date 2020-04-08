using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Julio_C_301016383.Models;

namespace Julio_C_301016383.Controllers
{
    public class HomeController : Controller
    {
        private IClubRepository clubsRepository;

        public HomeController(IClubRepository clubRepository)
        {
            clubsRepository = clubRepository;
        }

        public ViewResult Index()
        {
            
            return View();

        }

        [HttpGet]
        public IActionResult ClubPage()
        {
            return View("ClubPage", clubsRepository.Clubs);
        }

        [HttpGet]
        [Authorize(Roles = "GeneralUsers")]
        public ViewResult ManagePlayersPage(int playerID, int clubID)
        {
            // Filling the Combobox with clubs.
            List<Club> clubList = new List<Club> { new Club { ClubID = 0, Name = "Select..." } };
            clubList.AddRange(clubsRepository.Clubs);
            ViewBag.ListOfClubs = clubList;

            if (playerID == 0)
            {
                // Load the page with a new Player.
                Player player = new Player { ClubID = clubID };
                return View("ManagePlayersPage", player);
            }
            else
            {
                // Load the page with existing player.
                return View("ManagePlayersPage", clubsRepository.GetPlayer(playerID));
            }
        }

        [HttpPost]
        [Authorize(Roles = "GeneralUsers")]
        public IActionResult ManagePlayersPage(Player player)
        {
            // Filling the Combobox with clubs.
            List<Club> clubList = new List<Club> { new Club { ClubID = 0, Name = "Select..." } };
            clubList.AddRange(clubsRepository.Clubs);
            ViewBag.ListOfClubs = clubList;

            if (ModelState.IsValid)
            {
                clubsRepository.SavePlayer(player);
                TempData["message"] = $"{player.FirstName + " " + player.LastName} has been saved";
                return RedirectToAction("ClubPage", clubsRepository.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID));
            }
            else
            {
                return View("ClubPage", clubsRepository.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID));
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admins")]
        public IActionResult EditPlayers(int playerID, int clubID)
        {
            //EditPlayers?playerId=1&clubID=1
            List<Club> clubList = new List<Club> { new Club { ClubID = 0, Name = "Select..." } };
            clubList.AddRange(clubsRepository.Clubs);
            ViewBag.ListOfClubs = clubList;

            if(playerID == 0)
            {
                Player player = new Player { ClubID = clubID };
                return View("ManagePlayersPage", player);

            }else
            {
                return View("ManagePlayersPage", clubsRepository.GetPlayer(playerID));
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admins")]
        public IActionResult EditPlayers(Player player)
        {
            // Filling the Combobox with clubs.
            List<Club> clubList = new List<Club> { new Club { ClubID = 0, Name = "Select..." } };
            clubList.AddRange(clubsRepository.Clubs);
            ViewBag.ListOfClubs = clubList;

            if (ModelState.IsValid)
            {
                clubsRepository.SavePlayer(player);
                TempData["message"] = $"{player.FirstName + " " + player.LastName} has been saved";
                return RedirectToAction("ClubPage", clubsRepository.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID));
            }
            else
            {
                return View("ClubPage", clubsRepository.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID));
            }
        }

        [HttpGet]
        public ViewResult ClubDetailsPage(int clubID)
        {
            if (clubID == 0)
            {
                return View("ClubDetailsPage", clubsRepository.Clubs);
            }
            else
            {
                return View("ClubDetailsPage", clubsRepository.Clubs.Where(c => c.ClubID == clubID));
            }
        }

        [HttpGet]
        public IActionResult ClubList()
        {
            return View("ClubList", clubsRepository.Clubs);
        }

        [HttpPost]
        public IActionResult ClubList(int clubID)
        {
            if (ModelState.IsValid)
            {
                return View("ClubDetailsPage", clubsRepository.Clubs.Where(c => c.ClubID == clubID));
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admins")]
        public ViewResult AddClubPage(int clubID)
        {
            if (clubID == 0)
            {
                return View("AddClubPage", new Club());
            }
            else
            {
                return View(clubsRepository.Clubs
                .FirstOrDefault(c => c.ClubID == clubID));                
            }
        }
        [HttpPost]
        [Authorize(Roles = "Admins")]
        public IActionResult AddClubPage(Club club)
        {
            if (ModelState.IsValid)
            {
                clubsRepository.SaveClub(club);
                TempData["message"] = $"{club.Name} has been saved";
                return RedirectToAction("ClubPage");
            }
            else
            {          
                return View(club);
            }
        }


        [HttpPost]
        [Authorize(Roles = "Admins")]
        public IActionResult DeleteClub(int clubId)
        {
            Club deletedClub = clubsRepository.DeleteClub(clubId);
            if (deletedClub != null)
            {
                TempData["message"] = $"{deletedClub.Name} was deleted";
            }
            return RedirectToAction("ClubPage");
        }

        [Authorize(Roles = "Admins")]
        public IActionResult DeletePlayer(int PlayerId)
        {
            Player deletedPlayer = clubsRepository.DeletePlayer(PlayerId);
            if (deletedPlayer != null)
            {
                TempData["message"] = $"{deletedPlayer.FirstName+" "+deletedPlayer.LastName} was deleted";
            }
            return RedirectToAction("ClubDetailsPage", clubsRepository.Clubs.Where(c => c.ClubID == deletedPlayer.ClubID));
        }
    }
}