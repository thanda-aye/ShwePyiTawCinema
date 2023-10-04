using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models.ViewModel;
namespace ShwePyiTawCinema.Models.ViewModel
{
    public class TicketPriceTbl
    {
        [Key]
        public int ID { get; set; }         
        public string MovieType { get; set; }
        [Required(ErrorMessage = "Movie Type is required.")]
        [Display(Name = "Movie Type")]
        public string  ClassType { get; set; }
        [Required(ErrorMessage = "Class is required.")]
        [Display(Name = "Class")]
        public string Amt { get; set; }             
        public string Action { get; set; }
    }
}