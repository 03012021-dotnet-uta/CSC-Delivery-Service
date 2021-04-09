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
    public class HaikuController : ControllerBase
    {
        private readonly HaikuGenerator _haukuGenerator;

        public HaikuController(HaikuGenerator haukuGenerator){
            this._haukuGenerator = haukuGenerator;
        }

        [HttpGet]
        public ActionResult<string> getone(){
            
            return "one two three";
        } 
        public string GetOne(){
            return "one two three";
        }

    }
}
