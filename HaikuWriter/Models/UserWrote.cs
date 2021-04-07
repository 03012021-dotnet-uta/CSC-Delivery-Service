using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class UserWrote
    {
        [ForeignKey("User")] 
        public string Username { get; set; }
        [ForeignKey("Haiku")] 
        public int HaikuID { get; set; }
    }
}