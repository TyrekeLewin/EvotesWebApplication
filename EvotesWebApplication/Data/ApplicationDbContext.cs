using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvotesWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<Voters>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<Parishes> Parishes { get; set; }

    }
}