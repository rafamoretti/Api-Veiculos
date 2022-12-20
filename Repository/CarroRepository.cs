using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class CarroRepository : Repository<Carro>
    {
        private readonly AppDbContext _context;

        public CarroRepository(AppDbContext context) : base(context)
        { }
    }
}