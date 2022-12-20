using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class VeiculoMotorizado : VeiculoBase, IRegistravel
    {
        public int LitrosCombustivel { get; set; }
        public string Placa { get; set; }
        public DateTime DataRevisao { get; set; }

        public double QuilometragemPorLitro()
        {
            return base.Quilometros / this.LitrosCombustivel;
        }
    }
}