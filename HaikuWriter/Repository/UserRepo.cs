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
            Console.WriteLine(newUser.FirstName);
            Console.WriteLine(newUser.LastName);
            Console.WriteLine(newUser.MemberSince);
            Console.WriteLine(newUser.PasswordSalt);
            Console.WriteLine(newUser.FaceBookName);
            Console.WriteLine(newUser.AdminStatus);
            var newUser1 = _dbContext.Users.Add(newUser);// addd the new user to the Db
            _dbContext.SaveChanges();// save the change.
            return _dbContext.Users.FirstOrDefault(u => u.Username == newUser.Username);// default is null
        }

        public bool UserExists(string username)
        {
            Console.WriteLine(username);
            if (_dbContext.Users.Where(p => p.Username == username).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUserByUsername(string username)
        {
            //Console.WriteLine(username);
            User foundUser = _dbContext.Users.FirstOrDefault(p => p.Username == username);
            return foundUser;
        }
        
    }
}