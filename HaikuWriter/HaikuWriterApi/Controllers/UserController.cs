using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using BusinessLogic;

namespace HaikuWriterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserMethods _userMethods;

        public UserController(UserMethods userMethods){
            this._userMethods = userMethods;
        }

       [HttpPost("signup")]
        public ActionResult<User> signup([FromBody] RawUser user){

            Console.WriteLine("user");
            Console.WriteLine(user.Email);

            User newUser = _userMethods.UserRegister(user);
            
            return newUser;
        } 

        [HttpGet("login/{username}/{password}")]
        public ActionResult<User> login(string username, string password){


            User newUser = _userMethods.UserLogin(username, password);
            
            return newUser;
        } 

    }
}
