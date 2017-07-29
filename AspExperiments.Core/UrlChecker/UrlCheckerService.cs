using System;
using System.Net;

namespace AspExperiments.Core.UrlChecker
{
    public class UrlCheckerService : IUrlCheckerService
    {
        public bool IsUrlAvailable(string url, int timeout = 1000)
        {
            var request = WebRequest.Create(url);
            request.Method = "HEAD";
            request.Timeout = timeout;

            WebResponse response = null;
            try
            {
                response = request.GetResponse();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                response?.Close();
            }
        }
    }
}