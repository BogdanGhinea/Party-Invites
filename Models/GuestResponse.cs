using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="*Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Please enter your Phone")]
        [Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage = "*Please enter your Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Please enter your answer")]
        public bool? WillAttend { get; set; }
    }
}
