namespace ApiVeiculos.Model.Interfaces
{
    public interface ICalculadorDeImposto
    {
        double CalculaIPVA(IRegistravel veiculo);
    }
}