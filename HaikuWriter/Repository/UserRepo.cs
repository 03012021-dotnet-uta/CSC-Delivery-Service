using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repository
{
    public class UserRepo
    {
        private readonly HaikuDbContext _dbContext;

         public UserRepo(HaikuDbContext context){
            this._dbContext = context;
        }

        public User Register(User newUser)
        {
            Console.WriteLine(newUser.Username);
            Console.WriteLine(newUser.PasswordHash);
            var newUser1 = _dbContext.Users.Add(newUser);// addd the new user to the Db
            _dbContext.SaveChanges();// save the change.
            return _dbContext.Users.FirstOrDefault(u => u.Username == newUser.Username);// default is null
        }
        
    }
}