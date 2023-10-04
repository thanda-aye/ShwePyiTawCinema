using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class MovieTimeTbl
    {
        [Key]
        public int ID { get; set; }       
        public string MovieTime { get; set; }
    }
}