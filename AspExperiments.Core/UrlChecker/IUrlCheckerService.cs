namespace AspExperiments.Core.UrlChecker
{
    public interface IUrlCheckerService
    {
        /// <summary>
        /// Checks if web resource is available.
        /// </summary>
        /// <returns></returns>
        bool IsUrlAvailable(string url);
    }
}