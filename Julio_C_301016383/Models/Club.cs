using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Julio_C_301016383.Models
{
    public class Club
    {
             
        public int ClubID { get; set; }

        [Required(ErrorMessage = "Please enter a Club name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Club Address.")]
        public string Address { get; set; }

        public IEnumerable<Player> Players { get; set; }
    }
}
