using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using BusinessLogic;
using Models

namespace HaikuWriterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HaikuContorller : ControllerBase
    {
        private readonly HaikuGenerator _haukuGenerator;

        public HaikuContorller(HaikuGenerator haukuGenerator){
            this._haukuGenerator = haukuGenerator;
        }

        [HttpGet("one")]
        public ActionResult<string> getone(){
        
            return "one two three";
        } 

    }
}
