using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HaikuLine
    {   [Key]
        public int HaikuID { get; set; }
        public string Line { get; set; }
        public string Tags { get; set; }
        public int Syllable { get; set; }
        public bool Approved { get; set; }

    }
}