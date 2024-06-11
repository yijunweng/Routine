using Microsoft.EntityFrameworkCore;
using Routine.Api.Entities;

namespace Routine.Api.Data
{
    public class RoutineDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }




        public RoutineDbContext(DbContextOptions<RoutineDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
