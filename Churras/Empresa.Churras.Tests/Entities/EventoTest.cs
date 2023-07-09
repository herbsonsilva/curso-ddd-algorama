namespace Empresa.Churras.Tests.Entities;

public class EventoTest
{
    [Fact]
    public void ConfirmarPresenca_Test()
    {
        // Arrange
        var colega = new ColegaBuilder().Build();
        var evento = new EventoBuilder().Build();
        
        // Act
        evento.ConfirmarPresenca(colega, "1kg de carne + bebida");

        // Assert
        var confirmacao = evento.ColegasConfirmados
            .FirstOrDefault(x => x.ColegaKey.Equals(colega.Key));

        confirmacao.Should().NotBeNull("Colega deve ser encontrado na lista de confirmação");
        confirmacao!.ColegaKey.Should().Be(colega.Key, "Chave do Colega encontrado deve ser igual a Chave do Colega confirmado");
        confirmacao.ColegaNome.Should().Be(colega.Nome, "Nome do Colega encontrado deve ser igual ao Nome do Colega confirmado");
    }

    [Fact]
    public void CancelarPresenca_Test()
    {
        // Arrange
        var colega = new ColegaBuilder().Build();
        var evento = new EventoBuilder().Build();

        // Act
        evento.ConfirmarPresenca(colega, "1kg de carne + bebida");
        evento.CancelarPresenca(colega);

        // Assert
        var confirmacao = evento.ColegasConfirmados
            .FirstOrDefault(x => x.ColegaKey.Equals(colega.Key));

        confirmacao.Should().BeNull("Colega não deve ser encontrado na lista de confirmação");
    }
}
