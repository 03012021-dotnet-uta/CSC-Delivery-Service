using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [ForeignKey("Thread")]
        public int ThreadID { get; set; }
        [ForeignKey("User")]
        public string Username { get; set; }
    }
}