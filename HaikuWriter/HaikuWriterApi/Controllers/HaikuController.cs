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
        private readonly HaikuMethods _haikuMethod;

        public HaikuController(HaikuGenerator haukuGenerator, HaikuMethods haikuMethod){
            this._haukuGenerator = haukuGenerator;
            _haikuMethod = haikuMethod;
        }

        [HttpGet]
        public ActionResult<string> getone(){
            
            return "one two three";
        } 
        public string GetOne(){
            return "one two three";
        }

        [HttpGet("unapprovedHaikuLine")]
        public ActionResult<List<HaikuLine>> GetUnapprovedHaikuLines()
        {
            List<HaikuLine> haikuLinesList = _haikuMethod.GetUnapprovedHaikuLines();
            return haikuLinesList;
        }

    }
}
