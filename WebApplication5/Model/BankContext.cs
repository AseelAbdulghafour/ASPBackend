using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace WebApplication5.Model
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> op) : base(op)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankBranch>().HasData(
                new BankBranch
                {
                    Id = 1,
                    LocationName = "Alshamyia",
                    BranchManager = "Omar Alkandrii",
                    EmployeeCount = 21,
                    LocationURL = "https://maps.app.goo.gl/k5DD4wvKX38Y6RFQ7"
                }
            );
        }

        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}
