using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public class Tournament
    {
        public int TournamentID { get; set; }

        [Required(ErrorMessage = "Please enter a Club name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a number of clubs")]
        [Range(2, double.MaxValue, ErrorMessage = "Please enter a number of clubs at least 2")]
        public int ClubCount { get; set; }

        [Required(ErrorMessage = "Please enter tournament duration (From)")]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }

        [Required(ErrorMessage = "Please enter tournament duration (To)")]
        [DataType(DataType.Date)]
        public DateTime To { get; set; }

        [Required(ErrorMessage = "Please enter a Price for Ticket.")]
        public decimal Price { get; set; }

        public IEnumerable<Match> Matches { get; set; }
    }
}
