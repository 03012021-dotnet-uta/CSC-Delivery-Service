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

            User newUser = _userMethods.userRegister(user);
            
            return newUser;
        } 

    }
}
