using Repository;

namespace BusinessLogic
{
    public class HaikuGenerator
    {
<<<<<<< HEAD
        private readonly HaikuRepo _repo;
         
        private readonly UserRepo _repoUser;

        public HaikuGenerator(HaikuRepo repo, UserRepo repoUser){
            this._repo = repo;
            this._repoUser = repoUser;

        }
=======
        /*Repository _repo = new Repository;
>>>>>>> 46317af76271fa2681bf06e575334880587cc48b
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public HaikuGenerator()
        {
            Line1 = _repo.GetHaiku5();
            Line2 = _repo.GetHaiku7();
            Line3 = _repo.GetHaiku5();
        }
        */
    }
}