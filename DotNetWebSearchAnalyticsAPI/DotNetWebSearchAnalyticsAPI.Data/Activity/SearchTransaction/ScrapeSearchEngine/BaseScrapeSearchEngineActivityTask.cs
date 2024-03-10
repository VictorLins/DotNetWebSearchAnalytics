using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    public abstract class BaseScrapeSearchEngineActivityTask : CoActivityTask
    {
        #region [ Constructors ]

        public BaseScrapeSearchEngineActivityTask(ISearchTransactionRepository prISearchTransactionRepository, string prURL, string prSearchTerm, int prTakeResult, string prKeyword, string prSearchEngine)
        {
            _ISearchTransactionRepository = prISearchTransactionRepository;
            _SearchTransaction = new SearchTransaction();
            _SearchTransaction.Search_Engine = prSearchEngine;
            _SearchTransaction.Search_Term = prSearchTerm;
            _SearchTransaction.Keyword = prKeyword;
            _SearchTransaction.URL = GetURL(prURL, prSearchTerm, prTakeResult);
            _SearchTransaction.Date = DateTime.Now;
            _SearchTransaction.Result_Positions = "0";
            _SearchTransaction.Result_Quantity = 0;
        }

        #endregion

        #region [ Properties / Fields ]

        ISearchTransactionRepository _ISearchTransactionRepository;
        public SearchTransaction _SearchTransaction;

        #endregion

        protected abstract String GetURL(string prURL, string prSearchTerm, int prTakeResult);
        protected abstract String GetHTMLContent();
        protected abstract List<String> SplitHTMLContent(string prContent);

        protected override bool Semantic()
        {
            String lHTMLString = GetHTMLContent();

            if (string.IsNullOrWhiteSpace(lHTMLString) == false)
            {
                List<String> lEntries = SplitHTMLContent(lHTMLString);

                // Populate Positions and Quantity
                for (int i = 0; i < lEntries.Count; i++)
                {
                    if (lEntries[i].ToUpper().Contains(_SearchTransaction.Keyword.ToUpper()))
                    {
                        _SearchTransaction.Result_Positions = _SearchTransaction.Result_Positions == "0" ? (i + 1).ToString() : _SearchTransaction.Result_Positions + ", " + (i + 1);
                        _SearchTransaction.Result_Quantity++;
                    }
                }
            }

            return _CoMessageList.HasNotError();
        }

        protected override void PosConditional()
        {
            // Save Search
            SearchTransactionActivityCoordinator lSearchTransactionActivityCoordinator = new SearchTransactionActivityCoordinator(_ISearchTransactionRepository);
            lSearchTransactionActivityCoordinator.InsertSearchTransaction(_SearchTransaction);
        }
    }
}