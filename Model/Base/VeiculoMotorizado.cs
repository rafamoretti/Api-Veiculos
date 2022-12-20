using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class VeiculoMotorizado : VeiculoBase
    {
        public int LitrosCombustivel { get; set; }

        public double QuilometragemPorLitro()
        {
            return base.Quilometros / this.LitrosCombustivel;
        }
    }
}