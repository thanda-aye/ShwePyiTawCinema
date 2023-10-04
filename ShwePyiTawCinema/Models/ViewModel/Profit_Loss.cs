using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShwePyiTawCinema.Models.ViewModel;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class Profit_Loss
    {       
        public string MovieName { get; set; }
        public decimal TotalIncomes { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Profit { get; set; }
        public decimal Loss { get; set; }
        public Int32 Date { get; set; }
        public string PLDate { get; set; }
    }
}