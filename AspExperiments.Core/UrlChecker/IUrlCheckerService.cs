namespace AspExperiments.Core.UrlChecker
{
    public interface IUrlCheckerService
    {
        /// <summary>
        /// Checks if web resource is available.
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="timeout">Timeout in milliseconds</param>
        /// <returns>True if resource is available</returns>
        bool IsUrlAvailable(string url, int timeout = 1000);
    }
}