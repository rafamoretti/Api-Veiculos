using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class Moto : VeiculoMotorizado, IRegistravel
    {
        public string MaterialQuadro { get; set; }
        public string Placa { get; set; }
        public DateTime DataRevisao { get; set; }
    }
}