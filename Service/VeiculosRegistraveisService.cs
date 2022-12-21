using ApiVeiculos.Model;
using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Services
{
    public class VeiculosRegistraveisService : IVeiculosRegistraveisService
    {
        public bool VerificaRevisao(IRegistravel veiculo)
        {
            var concessionaria = new Concessionaria();
            return concessionaria.VerificaPrazoRevisao(veiculo);
        }
    }
}