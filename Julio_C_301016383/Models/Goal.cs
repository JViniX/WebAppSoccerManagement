using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public class Goal
    {
        public int GoalID { get; set; }

        public int MatchID { get; set; }

        public int? ClubID { get; set; }
        public int? PlayerID { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime? GoalTime { get; set; }
    }
}
