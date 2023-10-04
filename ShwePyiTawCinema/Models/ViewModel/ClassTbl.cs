using System.ComponentModel.DataAnnotations;

namespace ShwePyiTawCinema.Models.ViewModel
{
    public class ClassTbl
    {
        [Key]
        public int ID { get; set; }
        public string ClassType { get; set; }
        public string ClassLetter { get; set; }
        public string FromSeatNo { get; set; }         
        public string ToSeatNo { get; set; }
 
    }
}