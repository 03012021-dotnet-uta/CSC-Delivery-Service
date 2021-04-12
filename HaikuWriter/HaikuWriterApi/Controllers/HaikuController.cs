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
            _haukuGenerator = haukuGenerator;
            _haikuMethod = haikuMethod;
        }

        [HttpGet]
        public ActionResult<string> getone(){
            
            return "one two three";
        } 
        public string GetOne(){
            return "one two three";
        }

        /// <summary>
        /// Haiku Controller Route that will retrieve a random haiku to display
        /// </summary>
        /// <returns></returns>
        [HttpGet("generateHaiku")]
        public ActionResult<HaikuDTO> GenerateHaiku()
        {
            HaikuDTO haiku = _haukuGenerator.GenerateHaiku();
            return haiku;
        }

        // [HttpPost("writeHaiku")]
        // public ActionResult WriteHaiku([FromBody] string username)
        // {
        //     bool success = true;
        //     Console.WriteLine(username);

        //     return success;
        // }

        /// <summary>
        /// Haiku Controller Route to retrieve a list of unapproved haiku lines
        /// </summary>
        /// <returns></returns>
        [HttpGet("unapprovedHaikuLine")]
        public ActionResult<List<HaikuLine>> GetUnapprovedHaikuLines()
        {
            List<HaikuLine> haikuLinesList = _haikuMethod.GetUnapprovedHaikuLines();
            return haikuLinesList;
        }

        /// <summary>
        /// Haiku Controller route that retrieves a list of unapproved haikus
        /// </summary>
        /// <returns></returns>
        [HttpGet("unapprovedHaiku")]
        public ActionResult<List<Haiku>> GetUnapprovedHaikus()
        {
            List<Haiku> haikuList = _haikuMethod.GetUnapprovedHaikus();
            return haikuList;
        }

    }
}
