using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspExperiments.Core.UrlChecker;
using StructureMap;
using Xunit;

namespace AspExperiments.Core.Tests.UrlCheckerTests
{
    public class UrlCheckerTests
    {
        private readonly Container IoC;

        public UrlCheckerTests()
        {
            var registry = new Registry();
            registry.For<IUrlCheckerService>().Use<UrlCheckerService>();
            IoC = new Container(registry);
        }

        [Theory]
        [InlineData("https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", true)]
        [InlineData("https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png.Error", false)]
        public void ImageUrlCheckTest(string url, bool expectedResult)
        {
            var checker = IoC.GetInstance<IUrlCheckerService>();
            var result = checker.IsUrlAvailable(url);
            Assert.Equal(expectedResult, result);
        }
    }
}
