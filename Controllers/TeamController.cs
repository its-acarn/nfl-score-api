using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nflScoreApi.Models;

namespace nflScoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        public TeamController()
        {
        }

        [HttpGet]
        public Team GetTeam(string name)
        {
            return new Team
            {
                Name = name
            };
        }

        [HttpPost]
        public Team createTeam(string name)
        {
            return new Team 
            {
                Id = Guid.NewGuid(),
                Name = name
            };
        }
    }
}
