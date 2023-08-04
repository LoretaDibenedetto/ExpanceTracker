using ExpanceTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using Transaction = ExpanceTracker.Models.Transaction;

namespace ExpanceTracker.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
             
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
