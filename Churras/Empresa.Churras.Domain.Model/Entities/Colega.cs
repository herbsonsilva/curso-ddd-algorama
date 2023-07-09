namespace Empresa.Churras.Domain.Model.Entities;

public class Colega : EntityKeySeq
{
    public Colega(string nome, Endereco endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }

    public string Nome { get; private set; }
    public Endereco Endereco { get; private set; }

    public void AtribuirKey(long key)
    {
        Key = key;
    }
}