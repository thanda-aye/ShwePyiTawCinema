using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class DailyReport
    {
        [Key]
        public int I_ID { get; set; }    
        public string Income_Date { get; set; }
        public string Year { get; set; }
        [Required(ErrorMessage = "Ticket Sold is required.")]
        [Display(Name = "Ticket Sold")]
        public decimal TicketSold { get; set; }
        [Required(ErrorMessage = "Snacks Sold is required.")]
        [Display(Name = "Snacks Sold")]
        public decimal SnacksSold { get; set; }
        [Required(ErrorMessage = "Ads Income is required.")]
        [Display(Name = "Ads Income")]
        public decimal Ads_Income { get; set; }
        [Required(ErrorMessage = "Other Income is required.")]
        [Display(Name = "Ohter Income")]
        public decimal Other_Income { get; set; }         
        public int E_ID { get; set; }                
        public decimal Ads { get; set; }
        public decimal Diesels { get; set; }
        public decimal Machine { get; set; }
        public decimal Fees { get; set; }
        public decimal Cash { get; set; }
        public decimal E_Charges { get; set; }
        public decimal Salary { get; set; }
        public string ExpenseDate { get; set; }
    }
}