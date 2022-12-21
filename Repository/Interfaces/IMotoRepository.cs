using ApiVeiculos.Model;

namespace ApiVeiculos.Repository.Interfaces
{
    public interface IMotoRepository : IRepository<Moto>
    {
        string GetMaterialQuadro(int id);
    }
}