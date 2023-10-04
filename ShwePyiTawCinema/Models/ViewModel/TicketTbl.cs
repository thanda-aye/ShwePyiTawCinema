using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class TicketTbl
    {
        [Key]
        public int Ticket_ID { get; set; }
        public int MovieID { get; set; }
        [Required(ErrorMessage="Movie Name is required.")]
        [Display(Name="Movie Name")]
        public string MovieName { get; set; }
        public string Genres { get; set; }
        [Required(ErrorMessage = "Class Type is required.")]
        [Display(Name = "Class Type")]
        public string ClassType { get; set; }
        [Required(ErrorMessage = "Movie Type is required.")]
        [Display(Name = "Movie Type")]
        public string MovieType { get; set; }
        [Required(ErrorMessage = "Seat No is required.")]
        [Display(Name = "Seat No")]
        public string SeatNo { get; set; }
        [Required(ErrorMessage = "Ph Booking is required.")]
        [Display(Name = "Ph Booking")]
        public string PhBooking { get; set; }
        [Required(ErrorMessage = "Movie Date is required.")]
        [Display(Name = "Movie Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime MovieDate { get; set; }
        [Required(ErrorMessage = "Movie Time is required.")]
        [Display(Name = "Movie Time")]
        public string MovieTime { get; set; }
        [Required(ErrorMessage = "Ticket Price is required.")]
        [Display(Name = "Ticket Price")]
        public decimal Amt { get; set; }
          [Display(Name = "FREE")]
        public Boolean Free { get; set; }
        
    }
}