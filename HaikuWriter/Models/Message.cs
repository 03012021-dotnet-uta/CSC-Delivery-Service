using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string messageBody{set;get;}

        //ef relationship with user
        public int UserId { get; set; }
        public User User { get; set; }

        //ef relationship with thread
        public int ThreadId { get; set; }
        public Thread Thread { get; set; }
    }
}