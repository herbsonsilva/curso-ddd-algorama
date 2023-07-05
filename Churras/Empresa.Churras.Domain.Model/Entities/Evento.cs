namespace Empresa.Churras.Domain.Model.Entities;

public class Evento : EntityKeySeq
{
    public long DonoDaCasaKey { get; private set; }
    public Colega DonoDaCasa { get; private set; }
    public string TipoEvento { get; private set; }
    public DateTimeOffset Dia { get; private set; }
    public Periodo Periodo { get; private set; }
    public ICollection<EventoColegaConfirmado> ColegasConfirmados { get; private set; }
}
