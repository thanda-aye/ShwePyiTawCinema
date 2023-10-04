using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models.ViewModel;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class IncomesTbl
    {
        [Key]
        public int Income_ID { get; set; }               
        public string MovieName { get; set; }
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
        public string Desc { get; set; }
        [Required(ErrorMessage = "Income Date is required.")]
        [Display(Name = "Income Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime IncomeDate { get; set; }
    }
}