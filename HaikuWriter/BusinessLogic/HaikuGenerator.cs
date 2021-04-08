using Repository;

namespace BusinessLogic
{
    public class HaikuGenerator
    {
        Repository _repo = new Repository;
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public HaikuGenerator()
        {
            Line1 = _repo.GetHaiku5();
            Line2 = _repo.GetHaiku7();
            Line3 = _repo.GetHaiku5();
        }
        
    }
}