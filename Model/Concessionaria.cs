using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class Concessionaria : ICalculadorDeImposto
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

        public bool VerificaPrazoRevisao(IRegistravel veiculo)
        {
            if (DateTime.Now.Date > veiculo.DataRevisao)
                return true;

            return false;
        }

        public double CalculaIPVA()
        {
            //TODO: Exemplificar ISP
            return 1.0;
        }
    }
}