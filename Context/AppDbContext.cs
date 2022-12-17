using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}