using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class UserFav
    {
        [ForeignKey("Username")] 
        public string Username { get; set; }
        [ForeignKey("HaikuID")]                
        public int Haiku1 { get; set; }
        [ForeignKey("HaikuID")] 
        public int Haiku2 { get; set; }
        [ForeignKey("HaikuID")] 
        public int Haiku3 { get; set; }
    }
}