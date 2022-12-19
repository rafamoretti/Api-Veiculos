namespace ApiVeiculos.Model
{
    public abstract class VeiculoBase
    {
        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Fabricante { get; set; }
        public int Quilometros { get; set; }
    }
}