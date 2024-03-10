using Azure.Identity;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using System.IO.Pipes;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    internal class BingScrapeSearchEngineActivityTask : BaseScrapeSearchEngineActivityTask
    {
        #region [ Constructors ]

        public BingScrapeSearchEngineActivityTask(ISearchTransactionRepository prISearchTransactionRepository, string prURL, string prSearchTerm, int prTakeResult, string prKeyword, string prSearchEngine)
            : base(prISearchTransactionRepository, prURL, prSearchTerm, prTakeResult, prKeyword, prSearchEngine)
        {
        }

        #endregion

        protected override string GetURL(string prURL, string prSearchTerm, int prTakeResult)
        {
            // TODO

            return "";
        }

        protected override string GetHTMLContent()
        {
            string lResult = "";

            // TODO

            return lResult;
        }

        protected override List<string> SplitHTMLContent(string prContent)
        {
            // TODO

            return new List<string>();
        }
    }
}