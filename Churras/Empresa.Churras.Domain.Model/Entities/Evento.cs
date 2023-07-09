namespace Empresa.Churras.Domain.Model.Entities;

public class Evento : EntityKeySeq
{
    public Evento(string nome, long donoDaCasaKey, TipoEvento tipo, DateTimeOffset inicio, DateTimeOffset fim)
    {
        Nome = nome;
        DonoDaCasaKey = donoDaCasaKey;
        Tipo = tipo;
        Periodo = new(inicio, fim);
        ColegasConfirmados = new HashSet<EventoColegaConfirmado>();
    }

    public string Nome { get; private set; }
    public long DonoDaCasaKey { get; private set; }
    public Colega? DonoDaCasa { get; private set; }
    public TipoEvento Tipo { get; private set; }
    public Periodo Periodo { get; private set; }
    public ICollection<EventoColegaConfirmado> ColegasConfirmados { get; private set; }

    public void ConfirmarPresenca(Colega colega, string oQueVaiLevar)
    {
        ColegasConfirmados ??= new HashSet<EventoColegaConfirmado>();
        ColegasConfirmados.Add(new(colega.Key, colega.Nome, oQueVaiLevar));
    }

    public void CancelarPresenca(Colega colega)
    {
        ColegasConfirmados ??= new HashSet<EventoColegaConfirmado>();

        if (!ColegasConfirmados.Any()) return;

        var colegaConfirmado = ColegasConfirmados
            .FirstOrDefault(x => x.ColegaKey.Equals(colega.Key));

        if (colegaConfirmado is not null)
            ColegasConfirmados.Remove(colegaConfirmado);
    }
}
