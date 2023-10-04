using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class AddingClassType
    {
        [Key]
        public int ID { get; set; }
        public string Class { get; set; }         
    }
}