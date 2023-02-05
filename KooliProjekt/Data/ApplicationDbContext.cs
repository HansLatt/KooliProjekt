//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : DbContext  //enne oli ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KooliProjekt.Data.Päevik> Päevik { get; set; } = default!;
        public DbSet<KooliProjekt.Data.PäevikSisu> PäevikSisu { get; set; }
    }
}