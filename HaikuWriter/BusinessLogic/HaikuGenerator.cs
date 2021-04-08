using Repository;

namespace BusinessLogic
{
    public class HaikuGenerator
    {
<<<<<<< HEAD
        Repository _repo = new Repository;
=======
        private readonly HaikuRepo _repo;

        public HaikuGenerator(HaikuRepo repo)
        {
            _repo = repo;
        }

>>>>>>> e488a20a9f1107f486ead522c20c66a6c43a774d
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