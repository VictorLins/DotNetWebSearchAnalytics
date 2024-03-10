using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;

namespace DotNetWebSearchAnalyticsAPI.Data.Activity
{
    public class DeleteSearchTransactionActivityTask : CoActivityTask
    {
        #region [ Constructors ]

        public DeleteSearchTransactionActivityTask(SearchTransaction prSearchTransaction, ISearchTransactionRepository prISearchTransactionRepository)
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
            _ISearchTransactionRepository.Remove(_SearchTransaction);

            return _CoMessageList.HasNotError();
        }
    }
}