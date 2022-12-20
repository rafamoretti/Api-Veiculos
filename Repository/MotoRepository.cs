using ApiVeiculos.Context;
using ApiVeiculos.Model;
using ApiVeiculos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Repository
{
    public class MotoRepository : Repository<Moto>, IMotoRepository
    {
        public MotoRepository(AppDbContext context) : base(context)
        { }

        public string GetMaterialQuadro(int id)
        {
            return GetById(id).MaterialQuadro;
        }
    }
}