using Repository;
using Models;

namespace BusinessLogic
{
    public class HaikuGenerator
    {
        private readonly HaikuRepo _repo;
        private readonly UserRepo _userRepo;

        public HaikuGenerator(HaikuRepo repo)
        {
            _repo = repo;
        }

        public HaikuLine Line1 { get; set; }
        public HaikuLine Line2 { get; set; }
        public HaikuLine Line3 { get; set; }
        public void MakeHaiku()
        {
            Line1 = _repo.GetHaiku5();
            Line2 = _repo.GetHaiku7();
            Line3 = _repo.GetHaiku5(Line1);
            
        }

    }
}