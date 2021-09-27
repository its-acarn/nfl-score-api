using System;

namespace nflScoreApi.Models
{
  public class Score
  {
    public Guid Id { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
  }
}