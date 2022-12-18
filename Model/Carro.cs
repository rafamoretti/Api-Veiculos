namespace ApiVeiculos.Model
{
    public class Carro
    {
        public int CarroId { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public string Fabricante { get; private set; }
        public int Quilometros { get; private set; }
        public DateTime DataRevisao { get; private set; }

        public void SetPlaca(string placa)
        {
            this.Placa = placa;
        }

        public void SetCor(string cor)
        {
            this.Cor = cor;
        }

        public void SetFabricante(string fabricante)
        {
            this.Fabricante = fabricante;
        }

        public void SetQuilometros(int quilometros)
        {
            this.Quilometros = quilometros;
        }

        public void SetDataRevisao(DateTime dataRevisao)
        {
            this.DataRevisao = dataRevisao;
        }

        public double QuilometragemPorLitro(int quilometros, int quantidadeCombustivel)
        {
            return this.Quilometros / quantidadeCombustivel;
        }

        public bool VerificaPrazoRevisao()
        {
            if (DateTime.Now.Date > DataRevisao)
                return true;

            return false;
        }
    }
}