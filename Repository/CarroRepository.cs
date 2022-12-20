using ApiVeiculos.Context;
using ApiVeiculos.Model;
using ApiVeiculos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        public CarroRepository(AppDbContext context) : base(context)
        { }

        public int GetQuantidadeDeLugares(int id)
        {
            return GetById(id).QuantidadeLugares;
        }
    }
}