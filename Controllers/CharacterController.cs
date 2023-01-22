using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5_RPG.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet5_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character { Name = "Sam"}
        }; 

        [HttpGet("GetAll")]
        
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }
    }


}