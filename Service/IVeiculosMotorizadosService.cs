using ApiVeiculos.Model;
using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Services
{
    public interface IVeiculosMotorizadosService
    {
        double VerificaQuilometragemPorLitro(VeiculoMotorizado veiculo);
    }
}