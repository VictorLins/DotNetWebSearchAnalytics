using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    public class UpdateSearchTransactionActivityTask : CoActivityTask
    {
        #region [ Constructors ]

        public UpdateSearchTransactionActivityTask(SearchTransaction prSearchTransaction, ISearchTransactionRepository prISearchTransactionRepository)
        {
            _ISearchTransactionRepository = prISearchTransactionRepository;
            _SearchTransaction = prSearchTransaction;
        }

        #endregion

        #region [ Properties / Fields ]

        private ISearchTransactionRepository _ISearchTransactionRepository;
        private SearchTransaction _SearchTransaction;

        #endregion

        protected override bool Semantic()
        {
            _ISearchTransactionRepository.Update(_SearchTransaction);

            return _CoMessageList.HasNotError();
        }
    }
}