using ApiVeiculos.Model;
using Funcionarios.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto> Motos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarroConfiguration());
            modelBuilder.ApplyConfiguration(new MotoConfiguration());
        }
    }
}