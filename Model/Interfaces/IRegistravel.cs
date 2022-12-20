namespace ApiVeiculos.Model.Interfaces
{
    public interface IRegistravel
    {
        string Placa { get; set; }
        DateTime DataRevisao { get; set; }
    }
}