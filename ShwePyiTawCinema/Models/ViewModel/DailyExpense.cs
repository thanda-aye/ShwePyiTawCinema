using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ShwePyiTawCinema.Models.ViewModel
{
    public class DailyExpense
    {
        [Key]
        public int E_ID { get; set; }
        [Required(ErrorMessage = "Movie Date is required.")]
        [Display(Name = "Movie Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime MovieDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }        
        [Display(Name = "Advertising")]
        public Boolean Ads { get; set; }
        [Display(Name = "Diesel")]
        public Boolean Diesels { get; set; }
        [Display(Name = "Machine")]
        public Boolean Machine { get; set; }
        [Display(Name = "Movie Price")]
        public Boolean Fees { get; set; }
        [Display(Name = "Petty Cash")]
        public Boolean Cash { get; set; }
        [Display(Name = "Meter Bill")]
        public Boolean Electricity { get; set; }
        [Display(Name = "Salary")]
        public Boolean Salary { get; set; }
    }
}