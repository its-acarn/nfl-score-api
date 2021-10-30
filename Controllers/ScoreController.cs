using System;
using Microsoft.AspNetCore.Mvc;
using nflScoreApi.Models;

namespace nflScoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : ControllerBase
    {
        public ScoreController()
        {
        }

        [HttpPost]
        public Score guessScore(int homeScore, int awayScore)
        {
            return new Score
            {
                Id = Guid.NewGuid(),
                HomeScore = homeScore,
                AwayScore = awayScore
            };
        }
    }
}
