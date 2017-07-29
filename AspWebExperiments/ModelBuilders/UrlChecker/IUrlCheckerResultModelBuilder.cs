using System.Collections;
using System.Collections.Generic;
using AspWebExperiments.ViewModels.UrlChecker;

namespace AspWebExperiments.ModelBuilders.UrlChecker
{
    public interface IUrlCheckerResultModelBuilder
    {
        UrlCheckerStatusViewModel GetViewModel(IEnumerable<string> urls);
    }
}