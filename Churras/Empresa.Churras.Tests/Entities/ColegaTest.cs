namespace Empresa.Churras.Tests.Entities;

public class ColegaTest
{
    [Fact]
    public void AtribuirKey_Test()
    {
        // Arrange
        var colega = new ColegaBuilder().Build();

        // Act
        colega.AtribuirKey(1);

        // Assert
        colega.Key.Should().Be(1, "Chave nao corresponde a Chave informada");
    }
}
