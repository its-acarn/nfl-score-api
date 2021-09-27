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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // private readonly ILogger<WeatherForecastController> _logger;

        public TeamController()
        {
            // _logger = logger;
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
