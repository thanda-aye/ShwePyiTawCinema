using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models.ViewModel;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class MovieIncome
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal TotalAmt { get; set; }
    }
}