using Microsoft.EntityFrameworkCore;

namespace AnimalTracker.Models
{
  public class AnimalTrackerContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalTrackerContext(DbContextOptions options) : base(options) { }
  }
}