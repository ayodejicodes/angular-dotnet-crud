using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Employee> Employees { get; set; }
    }
}
