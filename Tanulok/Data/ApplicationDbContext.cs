using Microsoft.EntityFrameworkCore;
using Tanulok.Model;

namespace Tanulok.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ez maga fog bekerulni a migartionba ha itt csak egy dbset van akkor csak egy táblám lesz
        public DbSet<Diak> Diakok { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
