using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class RoleTbl
    {
        [Key]
        public int RoleID { get; set; }
        
        [Required(ErrorMessage = "*")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Role Type")]
        public string RoleType { get; set; }
    }
}