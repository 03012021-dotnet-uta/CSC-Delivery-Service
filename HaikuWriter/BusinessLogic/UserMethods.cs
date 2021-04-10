using Repository;
using Models;
using System;

namespace BusinessLogic
{

    public class UserMethods{

        private readonly UserRepo _userRepo;
        private readonly Hasher hasher = new Hasher();
        public UserMethods( UserRepo userrepo)
        {
            this._userRepo = userrepo;
        }


        public User userRegister(User user){


            User newUser = hasher.hashPassword(user.Password);
            //newUser.AdminStatus = user.AdminStatus;
            newUser.Username = user.Username;
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.Email = user.Email;
            newUser.FaceBookName = user.FaceBookName;
            newUser.TwitterName = user.TwitterName;
            newUser.MemberSince = DateTime.Now;
            

            User registerUser = _userRepo.Register(newUser);
            if(registerUser == null){
                return null;
            }

            registerUser.PasswordHash = null;
            registerUser.PasswordSalt = null;
            return registerUser;
        }
    }

}