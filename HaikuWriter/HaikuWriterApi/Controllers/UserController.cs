using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Models;

namespace HaikuWriterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // private readonly HaikuGenerator _haukuGenerator;

        // public UserController(HaikuGenerator haukuGenerator){
        //     this._haukuGenerator = haukuGenerator;
        // }

       [HttpPost("signup")]
        public ActionResult<User> signup([FromBody] User user){

            Console.WriteLine("user");
            Console.WriteLine(user);
            
            return user;
        } 

    }
}
