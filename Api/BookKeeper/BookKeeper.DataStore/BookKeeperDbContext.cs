using BookKeeper.Models;
using Microsoft.EntityFrameworkCore;

namespace BookKeeper.DataStore
{
    public class BookKeeperDbContext : DbContext
    {
        public DbSet<JournalEntry> JournalEntries { get; set; }

        public DbSet<Credit> Credits { get; set; }
        public DbSet<Debit> Debits { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountCategory> AccountCategories { get; set; }
        public BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options) : base(options)
        {

        }
    }
}
