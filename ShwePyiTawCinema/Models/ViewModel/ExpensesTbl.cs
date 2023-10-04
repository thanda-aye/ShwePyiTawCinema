using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models.ViewModel;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class ExpensesTbl
    {
        [Key]
        public int Expense_ID { get; set; }
        public int UserID { get; set; }
        public string Desc { get; set; }
        public decimal Ads { get; set; }
        public decimal Diesels { get; set; }
        public decimal Machine { get; set; }
        public decimal MovieFees { get; set; }
        public decimal PettyCash { get; set; }
        public decimal Electricity_Charges { get; set; }
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Expense Date is required.")]
        [Display(Name = "Expense Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]         
        public string ExpenseDate { get; set; }
        public string Year { get; set; }
       
        
    }
}