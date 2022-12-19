namespace ApiVeiculos.Model
{
    public class VeiculoMotorizado : VeiculoBase
    {
        public int LitrosCombustivel { get; set; }
        public DateTime DataRevisao { get; set; }

        public double QuilometragemPorLitro()
        {
            return base.Quilometros / this.LitrosCombustivel;
        }
    }
}