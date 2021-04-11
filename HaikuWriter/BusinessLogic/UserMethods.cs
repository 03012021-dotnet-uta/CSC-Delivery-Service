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


        public User UserRegister(RawUser user){


            User newUser = hasher.hashPassword(user.Password);
            newUser.AdminStatus = user.AdminStatus;
            newUser.Username = user.Username;
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.Email = user.Email;
            newUser.FaceBookName = user.FaceBookName;
            newUser.TwitterName = user.TwitterName;
            

            User registerUser = _userRepo.Register(newUser);
            if(registerUser == null){
                return null;
            }

            registerUser.PasswordHash = null;
            registerUser.PasswordSalt = null;
            return registerUser;
        }

        public User UserLogin(string username, string password){
             Console.WriteLine(" Here 12 " + username);
            if (!_userRepo.UserExists(username))
            {
                return null;
            }
            else{
                
                User foundUser = _userRepo.GetUserByUsername(username);

                // hash the provided password with the key from the found user
                byte[] hash = hasher.HashTheUsername(password, foundUser.PasswordSalt);

                if (CompareTwoHashes(foundUser.PasswordHash, hash))
                {
                    foundUser.PasswordHash = null;
                    foundUser.PasswordSalt = null;
                    return foundUser;
                }
                else return null;

            }
        }

        /// <summary>
        /// gets two arrays and compire them and return true or false
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private bool CompareTwoHashes(byte[] arr1, byte[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            //compare the hash of the inputted password and the found user
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}