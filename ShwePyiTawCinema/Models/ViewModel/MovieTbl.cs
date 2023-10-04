using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ShwePyiTawCinema.Models; 

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class MovieTbl
    {
        [Key]
        public int MovieID { get; set; }
        public int UserID { get; set; }
        //MovieName
        [Required(ErrorMessage = "Movie Name is required.")]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        //MovieType
        [Required(ErrorMessage = "Genre is required.")]
        [Display(Name = "Genre")]
        public string MovieType { get; set; }
        //MoviePrice
        [Required(ErrorMessage = "Movie Price is required.")]
        [Display(Name = "Movie Price")]
        public decimal MoviePrice { get; set; }
        //MovieDate
        [Required(ErrorMessage = "Start Date is required.")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        //EndDate
        [Required(ErrorMessage = "End Date is required.")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }        
        public DateTime CreatedDate { get; set; }      
        public string CreatedBy { get; set; }
        [Display(Name = "Duet")]
        public Boolean Duet { get; set; }
      
    }
}