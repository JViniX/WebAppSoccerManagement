using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Julio_C_301016383.Models
{
    public class Match
    {
        public int MatchID { get; set; }

        [Required(ErrorMessage = "Please enter the Stadium name.")]
        public string Stadium { get; set; }

        [Required(ErrorMessage = "Please enter the Macth Date and Time.")]
        public DateTime MatchDateAndTime { get; set; }

        [Required(ErrorMessage = "Please enter a Price for Ticket.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter the 1st Club which is going to play this match.")]
        public int ClubID1 { get; set; }
        public string Club1Name { get; set; }

        [Required(ErrorMessage = "Please enter the 2nd Club which is going to play this match.")]
        public int ClubID2 { get; set; }
        public string Club2Name { get; set; }

        [Required(ErrorMessage = "Please select the Tournament.")]
        public int TournamentID { get; set; }


        

        public string Name { get; set; }
        public bool IsFinished { get; set; }

        public List<Club> ClubList { get; set; }

        public int Club1Score { get; set; }
        public int Club2Score { get; set; }

        public IEnumerable<Goal> Goals { get; set; }
    }
}
