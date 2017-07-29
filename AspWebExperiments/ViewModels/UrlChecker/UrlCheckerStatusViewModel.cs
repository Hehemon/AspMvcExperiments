using System.Collections.Generic;
using AspWebExperiments.Models.UrlChecker;

namespace AspWebExperiments.ViewModels.UrlChecker
{
    public class UrlCheckerStatusViewModel
    {
        public List<UrlStatus> AvailableUrlStatuses { get; private set; }

        public UrlCheckerStatusViewModel()
        {
            AvailableUrlStatuses = new List<UrlStatus>();
        }
    }
}