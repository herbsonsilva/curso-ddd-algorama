using Kernel.Domain.Model.Entities;

namespace Empresa.Churras.Domain.Model.Entities;

public class Evento : EntityKeySeq
{
    public string? DonoDaCasa { get; private set; }
    public string? TipoEvento { get; private set; }
    public DateTimeOffset Dia { get; private set; }
    public string? Periodo { get; private set; }
    public string? ColegasQueConfirmaramPresenca { get; private set; }
    public string? OQueCadaColegaVaiLevar { get; private set; }
}
