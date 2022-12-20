using ApiVeiculos.Context;
using ApiVeiculos.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class MotoRepository : Repository<Moto>
    {
        private readonly AppDbContext _context;

        public MotoRepository(AppDbContext context) : base(context)
        { }
    }
}