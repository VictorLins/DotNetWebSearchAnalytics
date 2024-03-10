using DotNetWebSearchAnalyticsAPI.Data.Models;

namespace DotNetWebSearchAnalyticsAPI.Data.Repositories
{
    public interface ISearchTransactionRepository
    {
        ICollection<SearchTransaction> GetAll();
        abstract bool Insert(SearchTransaction prSearchTransaction);
        abstract bool Update(SearchTransaction prSearchTransaction);
        abstract bool Remove(SearchTransaction prSearchTransaction);
    }
}