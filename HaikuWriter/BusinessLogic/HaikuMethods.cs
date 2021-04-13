using System.Collections.Generic;
using Repository;
using Models;
using Newtonsoft.Json;

namespace BusinessLogic
{
    public class HaikuMethods
    {
        private readonly HaikuRepo _repolayer;
        public HaikuMethods() { }
        public HaikuMethods(HaikuRepo repolayer)
        {
            _repolayer = repolayer;
        }

        /// <summary>
        /// Method will pass request for a list of unapproved haiku lines to repolayer
        /// </summary>
        /// <returns></returns>
        public List<HaikuLine> GetUnapprovedHaikuLines()
        {
            List<HaikuLine> haikulines = _repolayer.GetUnapprovedHaikuLines();
            return haikulines;
        }

        /// <summary>
        /// Method will pass a request to the repolayer for a list of unapproved haiku
        /// It will then convert the list of unapproved haikus to DTO
        /// </summary>
        /// <returns></returns>
        public List<Haiku> GetUnapprovedHaikus()
        {
            List<Haiku> haikus = _repolayer.GetUnapprovedHaikus();
            return haikus;
        }

        /// <summary>
        /// Method will pass haikuline id to repolayer to update approval status
        /// </summary>
        /// <param name="hlid"></param>
        /// <returns></returns>
        public bool ApproveHaikuLine(int hlid)
        {
            bool haikuLineApproval = _repolayer.ApproveHaikuLine(hlid);
            return haikuLineApproval;
        }

        /// <summary>
        /// Method will pass request to the repolayer to delete a haiku line by id
        /// </summary>
        /// <param name="hlid"></param>
        /// <returns></returns>
        public bool DeleteHaikuLine(int hlid)
        {
            bool deletionSuccessful = _repolayer.DeleteHaikuLine(hlid);
            return deletionSuccessful;
        }

        // public bool DeleteHaiku(int hid)
        // {

        // }

    }
}