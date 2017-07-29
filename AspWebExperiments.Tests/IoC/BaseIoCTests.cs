using StructureMap;

namespace AspWebExperiments.Tests.IoC
{
    public abstract class BaseIoCTests
    {
        protected Container IoC { get; private set; }

        protected BaseIoCTests()
        {
            var registry = CreateContainerRegistry();
            IoC = new Container(registry);
        }

        protected virtual Registry CreateContainerRegistry()
        {
            return new Registry();
        }
    }
}