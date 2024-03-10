using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    public class SearchTransactionActivityCoordinator : CoActivityCoordinator
    {
        #region [ Constructors ]

        public SearchTransactionActivityCoordinator(ISearchTransactionRepository prISearchTransactionRepository)
        {
            _ISearchTransactionRepository = prISearchTransactionRepository;
        }

        #endregion

        #region [ Properties / Fields ]

        private ISearchTransactionRepository _ISearchTransactionRepository;

        #endregion

        // Insert
        public bool InsertSearchTransaction(SearchTransaction prSearchTransaction)
        {
            InsertSearchTransactionActivityTask lInsertSearchTransactionActivityTask = new InsertSearchTransactionActivityTask(prSearchTransaction, _ISearchTransactionRepository);
            lInsertSearchTransactionActivityTask.Action();

            _CoMessageList.AddRange(lInsertSearchTransactionActivityTask._CoMessageList);
            return _CoMessageList.HasNotError();
        }

        // Update
        public bool UpdateSearchTransaction(SearchTransaction prSearchTransaction)
        {
            UpdateSearchTransactionActivityTask lUpdateSearchTransactionActivityTask = new UpdateSearchTransactionActivityTask(prSearchTransaction, _ISearchTransactionRepository);
            lUpdateSearchTransactionActivityTask.Action();

            _CoMessageList.AddRange(lUpdateSearchTransactionActivityTask._CoMessageList);
            return _CoMessageList.HasNotError();
        }

        // Delete
        public bool RemoveSearchTransaction(SearchTransaction prSearchTransaction)
        {
            DeleteSearchTransactionActivityTask lRemoveSearchTransactionActivityTask = new DeleteSearchTransactionActivityTask(prSearchTransaction, _ISearchTransactionRepository);
            lRemoveSearchTransactionActivityTask.Action();

            _CoMessageList.AddRange(lRemoveSearchTransactionActivityTask._CoMessageList);
            return _CoMessageList.HasNotError();
        }

        // Scrape
        public bool ScrapeSearchEnginesForKeyword(string prURL, string prSearchTerm, int prTakeResult, string prKeyword, string prSearchEngine)
        {
            BaseScrapeSearchEngineActivityTask lGenericScrapeSearchEngineActivityTask = null;

            // Google
            lGenericScrapeSearchEngineActivityTask = new GoogleScrapeSearchEngineActivityTask(_ISearchTransactionRepository, prURL, prSearchTerm, prTakeResult, prKeyword, prSearchEngine);
            lGenericScrapeSearchEngineActivityTask.Action();

            _CoMessageList.AddRange(lGenericScrapeSearchEngineActivityTask._CoMessageList);
            return _CoMessageList.HasNotError();
        }

        // Gets
        public ICollection<SearchTransaction> GetAll()
        {
            return _ISearchTransactionRepository.GetAll().OrderByDescending(x => x.Id).ToList();
        }
    }
}