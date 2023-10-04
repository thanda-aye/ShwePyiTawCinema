using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class DetailByTicket
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string ClassType { get; set; }
        public int TotalSeats { get; set; }
        public decimal TotalFreeAmt { get; set; }
        public decimal TotalSoldAmt { get; set; }  
    }
}