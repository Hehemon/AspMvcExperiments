using System.Web.Mvc;
using System.Xml.XPath;
using AspExperiments.Core.UrlChecker;
using AspWebExperiments.Controllers;
using AspWebExperiments.Models.UrlChecker;
using AspWebExperiments.Tests.IoC;
using AspWebExperiments.ViewModels.UrlChecker;
using Moq;
using StructureMap;
using Xunit;

namespace AspWebExperiments.Tests.UrlChecker
{
    public class UrlCheckerControllerTests : BaseIoCTests
    {
        protected override Registry CreateContainerRegistry()
        {
            var registry =  base.CreateContainerRegistry();

            var urlCheckerServiceMock = new Mock<IUrlCheckerService>();
            urlCheckerServiceMock.Setup(m => m.IsUrlAvailable("ok", 1000)).Returns(true);
            urlCheckerServiceMock.Setup(m => m.IsUrlAvailable("error", 1000)).Returns(false);
            registry.For<IUrlCheckerService>().Use(context => urlCheckerServiceMock.Object);

            return registry;
        }

        [Theory]
        [InlineData("ok", true)]
        [InlineData("error", false)]
        public void TestStatusView(string url, bool expectedResult)
        {
            var controller = IoC.GetInstance<UrlCheckerController>();
            var result = controller.Status(url) as ViewResult;
            Assert.NotNull(result);
            Assert.Equal(expectedResult, ((UrlCheckerStatusViewModel)result.Model).AvailableUrlStatuses[0].Status == SuccessStatus.Ok);
        }
    }
}