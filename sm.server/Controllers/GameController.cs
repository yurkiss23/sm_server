using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sm.server.Models;

namespace sm.server.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GameController : ControllerBase
    {
        private static List<Solider> list = new List<Solider>();

        [HttpGet("{nick}")]
        public IActionResult Index(string nick)
        {
            var solider = list.FirstOrDefault(s => s.Nick == nick);
            if (solider != null)
            {
                list.Remove(solider);
            }
            return Ok(solider);
        }

        //постріл по об'єкту
        [HttpPost]
        public IActionResult Post([FromBody]Solider solider)
        {
            if (solider != null)
            {
                list.Add(solider);
            }
            return Ok();
        }
    }
}