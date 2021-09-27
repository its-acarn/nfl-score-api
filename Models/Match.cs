using System;

namespace nflScoreApi.Models
{
  public class Match
  {
    public Guid Id { get; set; }
    public Team HomeTeam { get; set; }
    public Team AwayTeam { get; set; }
  }
}