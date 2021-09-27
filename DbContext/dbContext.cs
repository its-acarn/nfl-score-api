using Microsoft.EntityFrameworkCore;

namespace nflScoreApi.Models
{
    public class nflScoreContext : DbContext
    {
        public nflScoreContext(DbContextOptions<nflScoreContext> options)
            : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; }
    }
}