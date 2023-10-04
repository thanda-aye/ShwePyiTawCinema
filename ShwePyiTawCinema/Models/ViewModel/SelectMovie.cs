using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class SelectMovie
    {
        [Key]
        public int MovieID { get; set; }
        public int UserID { get; set; }      
        public string MovieName { get; set; }     
        public string MovieType { get; set; }     
        public decimal MoviePrice { get; set; }      
        public string StartDate { get; set; }     
        public string EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Boolean Status { get; set; }
    }
}