namespace Repository
{
    public class UserRepo
    {
        private readonly HaikuDbContext _dbContext;

         public UserRepo(HaikuDbContext context){
            this._dbContext = context;
        }

        
    }
}