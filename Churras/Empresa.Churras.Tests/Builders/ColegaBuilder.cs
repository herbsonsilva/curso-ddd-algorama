namespace Empresa.Churras.Tests.Builders;

public class ColegaBuilder : BuilderBase<Colega>
{
    private readonly Colega _instance;

    public ColegaBuilder()
    {
        _instance = new(
            _faker.Name.FirstName(),
            new(
                _faker.Address.ZipCode(),
                _faker.Address.StreetName(),
                _faker.Address.BuildingNumber(),
                _faker.Address.StreetSuffix(),
                _faker.Address.Locale,
                _faker.Address.City(),
                _faker.Address.State()
            )
        );
        _instance.AtribuirKey(_faker.UniqueIndex);
    }

    public ColegaBuilder ComKey(long key)
    {
        _instance.AtribuirKey(key);
        return this;
    }

    public override Colega Build()
    {
        return _instance;
    }
}
