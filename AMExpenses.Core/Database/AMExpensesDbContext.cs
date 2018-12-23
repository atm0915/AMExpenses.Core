using Microsoft.EntityFrameworkCore;
using AMExpenses.Core.Entities;

namespace AMExpenses.Core.Database
{
    public class AMExpensesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AMExpensesConnectionString.GetConnectionString());
        }
    }
}