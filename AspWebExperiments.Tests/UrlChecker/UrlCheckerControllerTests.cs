using System.Web.Mvc;
using System.Xml.XPath;
using AspWebExperiments.Controllers;
using AspWebExperiments.Models.UrlChecker;
using AspWebExperiments.Tests.IoC;
using AspWebExperiments.ViewModels.UrlChecker;
using StructureMap;
using Xunit;

namespace AspWebExperiments.Tests.UrlChecker
{
    public class UrlCheckerControllerTests : BaseIoCTests
    {
        protected override Registry CreateContainerRegistry()
        {
            var registry =  base.CreateContainerRegistry();
            return registry;
        }

        [Theory]
        [InlineData("https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png", true)]
        [InlineData("https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png.Error", false)]
        public void TestStatusView(string url, bool expectedResult)
        {
            //var controller = new UrlCheckerController();
            //var result = controller.Status(url) as ViewResult;
            //Assert.NotNull(result);
            //Assert.Equal(expectedResult, ((UrlCheckerStatusViewModel) result.Model).AvailableUrlStatuses[0].Status == SuccessStatus.Ok);
        }
    }
}