using System.Collections.Generic;
using Repository;
using Models;

namespace BusinessLogic
{
    public class HaikuMethods
    {
        private readonly HaikuRepo _repolayer;
        public HaikuMethods(){}
        public HaikuMethods(HaikuRepo repolayer)
        {
            _repolayer = repolayer;
        }

        public List<HaikuLine> GetUnapprovedHaikuLines()
        {
            List<HaikuLine> haikulines = _repolayer.GetUnapprovedHaikuLines();
            return haikulines;
        }

        public List<Haiku> GetUnapprovedHaikus()
        {
            List<Haiku> haikus = _repolayer.GetUnapprovedHaikus();
            return haikus;
        }
        
    }
}