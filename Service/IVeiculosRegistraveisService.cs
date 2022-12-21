using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Services
{
    public interface IVeiculosRegistraveisService
    {
        bool VerificaRevisao(IRegistravel veiculo);
    }
}