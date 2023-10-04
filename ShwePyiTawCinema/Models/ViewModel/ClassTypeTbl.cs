using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class ClassTypeTbl
    {
        [Key]
        public int ID { get; set; }
        public string ClassType { get; set; }        

    }
}