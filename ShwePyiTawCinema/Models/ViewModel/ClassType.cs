using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class ClassType
    {
        //ClassID
        [Key]
        public int Class_ID { get; set; } 
        public string MovieName { get; set; }

        //MovieDate
        [Required(ErrorMessage = "Movie Date is required.")]
        [Display(Name = "Movie Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime MovieDate { get; set; }         
        
        //ClassType       
        [Required(ErrorMessage = "Class Type is required.")]
        [Display(Name = "Class Type")]
        public string Class_Type { get; set; }

        //SoldOutSeat
        [Required(ErrorMessage = "SoldOut Seats is required.")]
        [Display(Name = "SoldOut Seats")]
        public string SoldOutSeats { get; set; }

        //TotalSoldOut
        [Required(ErrorMessage = "Total SoldOuts is required.")]
        [Display(Name = "Total SoldOuts")]
        public int TotalSoldOuts { get; set; }

        //AvailableSeat         
        [Required(ErrorMessage = "Available Seats is required.")]
        [Display(Name = "Available Seats")]
        public string AvailableSeats { get; set; }

        //TotalAvailable
        [Required(ErrorMessage = "Total Available is required.")]
        [Display(Name = "Total Available")]
        public int TotalAvailable { get; set; }


        [Required(ErrorMessage = "Ticket Price is required.")]
        [Display(Name = "Ticket Price")]
        public decimal Amt { get; set; }

       
    }
}