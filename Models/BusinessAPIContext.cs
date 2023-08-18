using Microsoft.EntityFrameworkCore;


namespace BuisnessAPI.Models
{
  public class BuisnessAPIContext : DbContext
  {
    public DbSet<Business> Business { get; set; }

    public BuisnessAPIContext(DbContextOptions<BuisnessAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {



    }
  }
}