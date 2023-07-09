namespace Empresa.Churras.Domain.Model.ValueObjects;

public class Endereco : ValueObject
{
    public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, double latitude = 0, double longitude = 0)
    {
        Cep = cep;
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Coordenada = new(latitude, longitude);
    }

    public string Cep { get; private set; }
    public string Logradouro { get; private set; }
    public string Numero { get; private set; }
    public string Complemento { get; private set; }
    public string Bairro { get; private set; }
    public string Cidade { get; private set; }
    public string Estado { get; private set; }
    public Coordenada Coordenada { get; private set; }
}
