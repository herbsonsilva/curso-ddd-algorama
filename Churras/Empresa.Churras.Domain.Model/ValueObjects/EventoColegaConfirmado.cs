namespace Empresa.Churras.Domain.Model.ValueObjects;

public class EventoColegaConfirmado : ValueObject
{
    public long ColegaKey { get; private set; }
    public string ColegaNome { get; private set; }
    public string OQueVaiLevar { get; private set; }
}
