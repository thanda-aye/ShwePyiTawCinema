using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class UserTbl
    {
        //ID
        [Key]
        public int UserID { get; set; }

        //UserName
        [Required(ErrorMessage = "*")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        //Password
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //LogInDate
        public DateTime LogInDate { get; set; }
        //LoginTime
        public DateTime LogInTime { get; set; }

    }
}