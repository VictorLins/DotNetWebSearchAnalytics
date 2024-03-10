using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using System.Net;
using System.Text;
using System.Web;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    internal class GoogleScrapeSearchEngineActivityTask : BaseScrapeSearchEngineActivityTask
    {
        #region [ Constructors ]

        public GoogleScrapeSearchEngineActivityTask(ISearchTransactionRepository prISearchTransactionRepository, string prURL, string prSearchTerm, int prTakeResult, string prKeyword, string prSearchEngine)
            : base(prISearchTransactionRepository, prURL, prSearchTerm, prTakeResult, prKeyword, prSearchEngine)
        {
        }

        #endregion

        protected override string GetURL(string prURL, string prSearchTerm, int prTakeResult)
        {
            // https://www.google.co.uk/search?
            //"https://www.google.co.uk/search?num=100&q=land+registry+search"
            return $"{prURL}num={prTakeResult}&q={prSearchTerm}";
        }

        protected override string GetHTMLContent()
        {
            string lResult = "";
            string lSearch = string.Format(_SearchTransaction.URL, HttpUtility.UrlEncode(_SearchTransaction.Keyword));
            HttpWebRequest lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lSearch);
            using (HttpWebResponse lHttpWebResponse = (HttpWebResponse)lHttpWebRequest.GetResponse())
            {
                using (StreamReader lStreamReader = new StreamReader(lHttpWebResponse.GetResponseStream(), Encoding.ASCII))
                {
                    lResult = lStreamReader.ReadToEnd();
                }
            }

            return lResult;
        }

        protected override List<string> SplitHTMLContent(string prContent)
        {
            return prContent.Split("egMi0 kCrYT").ToList();
        }
    }
}