using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    public class InsertSearchTransactionActivityTask : CoActivityTask
    {
        #region [ Constructors ]

        public InsertSearchTransactionActivityTask(SearchTransaction prSearchTransaction, ISearchTransactionRepository prISearchTransactionRepository)
        {
            _SearchTransactionRepository = prISearchTransactionRepository;
            _SearchTransaction = prSearchTransaction;
        }

        #endregion

        #region [ Properties / Fields ]

        private ISearchTransactionRepository _SearchTransactionRepository;
        private SearchTransaction _SearchTransaction;

        #endregion

        protected override bool Semantic()
        {
            _SearchTransactionRepository.Insert(_SearchTransaction);

            return _CoMessageList.HasNotError();
        }
    }
}