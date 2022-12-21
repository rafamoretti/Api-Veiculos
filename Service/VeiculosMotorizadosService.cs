using ApiVeiculos.Model;
using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Services
{
    public class VeiculosMotorizadosService : IVeiculosMotorizadosService
    {
        public double VerificaQuilometragemPorLitro(VeiculoMotorizado veiculo)
        {
            return veiculo.QuilometragemPorLitro();
        }
    }
}