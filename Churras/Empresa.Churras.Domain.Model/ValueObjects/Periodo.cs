namespace Empresa.Churras.Domain.Model.ValueObjects;

public class Periodo : ValueObject
{
    public Periodo(DateTimeOffset inicio, DateTimeOffset fim)
    {
        Inicio = inicio;
        Fim = fim;
    }

    public DateTimeOffset Inicio { get; private set; }
    public DateTimeOffset Fim { get; private set; }
}
