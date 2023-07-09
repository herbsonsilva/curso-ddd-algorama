namespace Empresa.Churras.Domain.Model.ValueObjects;

public class EventoColegaConfirmado : ValueObject
{
    public EventoColegaConfirmado(long colegaKey, string colegaNome, string oQueVaiLevar)
    {
        ColegaKey = colegaKey;
        ColegaNome = colegaNome;
        OQueVaiLevar = oQueVaiLevar;
    }

    public long ColegaKey { get; private set; }
    public string ColegaNome { get; private set; }
    public string OQueVaiLevar { get; private set; }
}
