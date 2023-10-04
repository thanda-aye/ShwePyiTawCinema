using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class SignUpTbl
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage="*")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Passowrd { get; set;  }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Confirmed Password")]
        public string ConfirmedPassword { get; set; }       
    }
}