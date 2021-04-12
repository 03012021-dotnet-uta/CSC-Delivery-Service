using System.Collections.Generic;
using System.Linq;
using System;
using Models;

namespace Repository
{
    public class HaikuRepo
    {
        private readonly HaikuDbContext _dbContext;

         public HaikuRepo(HaikuDbContext context){
            this._dbContext = context;
        }

        public HaikuLine SaveLine(HaikuLine haikuline)
        {
            var newLine = _dbContext.HaikuLines.Add(haikuline);//add the new line to the database
            _dbContext.SaveChanges();
            return _dbContext.HaikuLines.FirstOrDefault(h => h.HaikuLineId == haikuline.HaikuLineId);
        }

        public Haiku SaveHaiku(Haiku haiku)
        {
            var newHaiku = _dbContext.Haikus.Add(haiku);
            _dbContext.SaveChanges();
            return _dbContext.Haikus.FirstOrDefault(h => h.HaikuId == haiku.HaikuId);
        }
        public HaikuLine GetHaiku5()
        {
            Random random = new Random();
            int numrows = _dbContext.HaikuLines.Where(h => h.Syllable == 5).Select(h => h.HaikuLineId).Count();
            var rand = random.Next(numrows);
            var line = _dbContext.HaikuLines.Where(h => h.Syllable == 5).OrderBy(h => h.HaikuLineId).Skip(rand).Take(1).First();
            if(line.Syllable == 5){
                return line;
            }
            return null;
        }

        public HaikuLine GetHaiku7()
        {
            Random random = new Random();
            int numrows = _dbContext.HaikuLines.Where(h => h.Syllable == 7).Select(h => h.HaikuLineId).Count();
            var rand = random.Next(numrows);
            var line = _dbContext.HaikuLines.Where(h => h.Syllable == 7).OrderBy(h => h.HaikuLineId).Skip(rand).Take(1).First();
            if(line.Syllable == 7){
                return line;
            }
            return null;
        }
        public HaikuLine GetHaiku5(HaikuLine alreadyUsed)
        {
                 //get haiku line from DB
            HaikuLine newHaikuLine = GetHaiku5();
            
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