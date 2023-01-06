// Needed for accessing database

using Microsoft.EntityFrameworkCore;


namespace Factory.Models 
{
  public class FactoryContext : DbContext 
  {
    public DbSet<ClassName> ClassNames { get; set; }  // CHANGE CLASS NAME!!!

    public FactoryContext(DbContextOptions options) : base(options) { } 
  }
}