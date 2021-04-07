namespace Repository
{
    public class HaikuRepo
    {
        private readonly HaikuDbContext _dbContext;

         public HaikuRepo(HaikuDbContext context){
            this._dbContext = context;
        }

        public string GetHaiku5(){

            return null;
        }

        public string GetHaiku7(){

            return null;
        }
    }
}