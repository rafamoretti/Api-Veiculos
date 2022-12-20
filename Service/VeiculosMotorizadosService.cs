using ApiVeiculos.Model;
using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Services
{
    public class VeiculosMotorizadosService
    {
        public double VerificaQuilometragemPorLitro(VeiculoMotorizado veiculo)
        {
            return veiculo.QuilometragemPorLitro();
        }

        public bool VerificaRevisao(IRegistravel veiculo)
        {
            var concessionaria = new Concessionaria();
            return concessionaria.VerificaPrazoRevisao(veiculo);
        }
    }
}