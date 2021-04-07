using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Thread
    {
        [Key]
        public int ThreadID { get; set; }
        [ForeignKey("User")] 
        public string user { get; set; }
        public string Description { get; set; }
    }
}