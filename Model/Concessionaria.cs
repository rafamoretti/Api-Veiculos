using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class Concessionaria : ICalculadorDeImposto
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public bool VerificaPrazoRevisao(IRegistravel veiculo)
        {
            if (DateTime.Now.Date > veiculo.DataRevisao)
                return true;

            return false;
        }

        public double CalculaIPVA(IRegistravel veiculo)
        {
            //TODO: Exemplificar ISP
            return 1.0;
        }
    }
}