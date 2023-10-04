using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class MovieByTotals
    {
        [Key]
        public int MovieID { get; set; }              
        public string MovieName { get; set; }
        public string Genre { get; set; }   
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DisplayedDate { get; set; }
        public string TotalSeats { get; set; }
        public decimal TotalSoldAmt { get; set; }
        public decimal TotalFreeAmt { get; set; }
        
    }

    public class TotalList
    {
        public List<MovieByTotals> ByTotals { get; set; }
    }
    

}