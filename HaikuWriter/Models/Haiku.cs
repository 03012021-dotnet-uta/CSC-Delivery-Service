using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Haiku
    {
        [Key]
        public int HaikuId { get; set; }
         public HaikuLine HaikuLine1 { get; set; }
        public HaikuLine HaikuLine2 { get; set; }
        public HaikuLine HaikuLine3 { get; set; }
        public string Tags { get; set; }
        public bool Approved { get; set; }

        //ef relationship with user
        public string Username { get; set; }
        public User User { get; set; }
        //ef relationship with userfavorites
        public ICollection<UserFav> UserFavs { get; set; }

       
    }
}