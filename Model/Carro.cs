using ApiVeiculos.Model.Interfaces;

namespace ApiVeiculos.Model
{
    public class Carro : VeiculoMotorizado, IRegistravel
    {
        public int QuantidadeLugares { get; set; }
        public string Placa { get; set; }
        public DateTime DataRevisao { get; set; }

        public void AbrirCapo()
        {
            //TODO: Exemplificar LSP;
        }
    }
}