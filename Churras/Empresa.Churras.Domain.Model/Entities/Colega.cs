namespace Empresa.Churras.Domain.Model.Entities;

public class Colega : EntityKeySeq
{
    public string? Nome { get; private set; }
    public string? Endereco { get; private set; }
}