namespace Empresa.Churras.Domain.Model.ValueObjects;

public class Coordenada : ValueObject
{
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
}
