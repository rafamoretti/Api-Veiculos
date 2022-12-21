using ApiVeiculos.Model;

namespace ApiVeiculos.Repository.Interfaces
{
    public interface ICarroRepository : IRepository<Carro>
    {
        int GetQuantidadeDeLugares(int id);
    }
}