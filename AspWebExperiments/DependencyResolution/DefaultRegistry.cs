using AspExperiments.Core.UrlChecker;
using AspWebExperiments.ModelBuilders.UrlChecker;
using StructureMap;

namespace AspWebExperiments.DependencyResolution
{
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;

    public class DefaultRegistry : Registry
    {
        #region Constructors and Destructors

        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.With(new ControllerConvention());
                });

            For<IUrlCheckerService>().Use<UrlCheckerService>();
            For<IUrlCheckerResultModelBuilder>().Use<UrlCheckerResultModelBuilder>();
        }

        #endregion
    }
}