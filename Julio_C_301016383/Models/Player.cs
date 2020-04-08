using System.ComponentModel.DataAnnotations;

namespace Julio_C_301016383.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Required(ErrorMessage = "Please enter the First Name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the Last Name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the player's Age.")]
        public int Age { get; set; }
        public int ClubID { set; get; }
                
    }
    
}
