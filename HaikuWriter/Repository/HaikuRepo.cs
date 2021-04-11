using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repository
{
    public class HaikuRepo
    {
        private readonly HaikuDbContext _dbContext;

         public HaikuRepo(HaikuDbContext context){
            this._dbContext = context;
        }

        public string GetHaiku5()
        {

            return null;
        }

        public string GetHaiku7()
        {

            return null;
        }
        public string GetHaiku5(string alreadyUsed)
        {
                 //get haiku line from DB
            string newHaikuLine = "";
            
                //If the haikuline is not the same as the first line, return
            if(newHaikuLine != alreadyUsed){
                return newHaikuLine; //Passes the new haiku line to the caller
            }else{
                //If the lines are the same, recursively call the method again
                // It will check if the new line recieved is the same or not
                // It will call the method again if they are the same again
                // It will return here, if they are not the same.
               return GetHaiku5(alreadyUsed);
            }
        }

        public List<HaikuLine> GetUnapprovedHaikuLines()
        {
            List<HaikuLine> haikuLines = _dbContext.HaikuLines
                                                    .Where(hl => hl.Approved == false).ToList();
            return haikuLines;
        }
    }
}