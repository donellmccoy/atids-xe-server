using Microsoft.EntityFrameworkCore;

namespace TheFund.AtidsXe.Data.Context
{
    public partial class ATIDSXEContext : DbContext
    {
        public ATIDSXEContext()
        {
        }

        public ATIDSXEContext(DbContextOptions<ATIDSXEContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
