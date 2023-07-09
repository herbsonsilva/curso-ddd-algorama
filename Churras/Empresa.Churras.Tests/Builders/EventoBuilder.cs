namespace Empresa.Churras.Tests.Builders;

public class EventoBuilder : BuilderBase<Evento>
{
    private readonly Evento _instance;

    public EventoBuilder()
    {
        _instance = new(
            "Churras na Casa do Ary",
            1,
            TipoEvento.Churras,
            new DateTimeOffset(2023, 7, 8, 9, 0, 0, TimeSpan.Zero),
            new DateTimeOffset(2023, 7, 8, 16, 0, 0, TimeSpan.Zero)
        );
    }

    public override Evento Build()
    {
        return _instance;
    }
}
