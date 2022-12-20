using ApiVeiculos.Model;

namespace ApiVeiculos.Services
{
    public class VeiculosMotorizadosService
    {
        public double VerificaQuilometragemPorLitro(VeiculoMotorizado veiculo)
        {
            return veiculo.QuilometragemPorLitro();
        }

        public bool VerificaRevisao(VeiculoMotorizado veiculo)
        {
            var concessionaria = new Concessionaria();
            return concessionaria.VerificaPrazoRevisao(veiculo);
        }
    }
}