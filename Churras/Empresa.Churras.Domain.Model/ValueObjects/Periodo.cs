namespace Empresa.Churras.Domain.Model.ValueObjects;

public class Periodo : ValueObject
{
    public DateTimeOffset Inicio { get; private set; }
    public DateTimeOffset Fim { get; private set; }
}
