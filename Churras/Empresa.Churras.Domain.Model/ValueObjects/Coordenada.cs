namespace Empresa.Churras.Domain.Model.ValueObjects;

public class Coordenada : ValueObject
{
    public Coordenada(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
}
