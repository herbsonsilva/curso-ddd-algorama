using Bogus;

namespace Empresa.Churras.Tests.Builders;

public abstract class BuilderBase<T> where T : class
{
    protected readonly Faker _faker = new();

    public abstract T Build();
}
