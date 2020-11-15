using Microsoft.EntityFrameworkCore;
using OurMoneyBlazor.Shared.Entities;

namespace OurMoneyBlazor.Server.DataProvider
{
    public partial class OurMoneyDbContext : DbContext
    {
        //public OurMoneyDbContext()
        //    : base("name=OurMoneyDbContext")
        //{
        //}
        public OurMoneyDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Dictionary> Dictionaries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
    }
}
