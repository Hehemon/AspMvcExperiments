using System.Collections.Generic;
using System.Linq;
using AspExperiments.Core.UrlChecker;
using AspWebExperiments.Models.UrlChecker;
using AspWebExperiments.ViewModels.UrlChecker;

namespace AspWebExperiments.ModelBuilders.UrlChecker
{
    public class UrlCheckerResultModelBuilder : IUrlCheckerResultModelBuilder
    {
        private readonly IUrlCheckerService _urlCheckerService;

        public UrlCheckerResultModelBuilder(IUrlCheckerService checkerService)
        {
            _urlCheckerService = checkerService;
        }

        public UrlCheckerStatusViewModel GetViewModel(IEnumerable<string> urls)
        {
            var vm = new UrlCheckerStatusViewModel();
            vm.AvailableUrlStatuses.AddRange(urls.Select(url => new UrlStatus
            {
                Path = url,
                Status = _urlCheckerService.IsUrlAvailable(url) ? SuccessStatus.Ok : SuccessStatus.Error,
            }));
            return vm;
        }
    }
}