using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AspExperiments.Core.UrlChecker;
using TechTalk.SpecFlow;
using Xunit;

namespace AspExperiments.Core.Tests.UrlCheckerTests.Steps
{
    [Binding]
    public sealed class UrlCheckerSteps
    {
        private static string UrlLink = "UrlLink";

        [Given(@"I have an UrlChecker")]
        public void GivenIHaveAnUrlChecker()
        {
            FeatureContext.Current.Set<IUrlCheckerService>(new UrlCheckerService());
        }

        [When(@"I have '(.*)' link")]
        public void WhenIHaveLink(string urlLink)
        {
            FeatureContext.Current[UrlLink] = urlLink;
        }

        [Then(@"The result should be '(.*)'")]
        public void ThenTheResultShouldBe(bool expectedResult)
        {
            var urlCheckerService = FeatureContext.Current.Get<IUrlCheckerService>();
            var urlLink = (string) FeatureContext.Current[UrlLink];
            var result = urlCheckerService.IsUrlAvailable(urlLink);
            Assert.Equal(expectedResult, result);
        }
    }
}
