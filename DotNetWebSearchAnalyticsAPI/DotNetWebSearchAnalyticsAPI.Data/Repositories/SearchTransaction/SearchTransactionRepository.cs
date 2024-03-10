using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebSearchAnalyticsAPI.Data.Repositories
{
    public class SearchTransactionRepository : CoRepository, ISearchTransactionRepository
    {
        #region [ Constructors ]

        public SearchTransactionRepository(ApplicationDbContext prApplicationDbContext) : base(prApplicationDbContext)
        {
            ApplicationDbContext = prApplicationDbContext;
        }

        #endregion

        public DbSet<SearchTransaction> SearchTransactions { get; set; }
        public ApplicationDbContext ApplicationDbContext;

        // Generic Methods
        protected override void Add(CoEntity prCoEntity)
        {
            ApplicationDbContext.SearchTransactions.Add((SearchTransaction)prCoEntity);
        }

        protected override CoEntity Find(CoEntity prCoEntity)
        {
            return ApplicationDbContext.SearchTransactions.Find(GetId(prCoEntity));
        }

        protected override void Remove(CoEntity prCoEntity)
        {
            ApplicationDbContext.SearchTransactions.Remove((SearchTransaction)prCoEntity);
        }

        // Base Class

        ICollection<SearchTransaction> ISearchTransactionRepository.GetAll()
        {
            return ApplicationDbContext.SearchTransactions.ToList();
        }

        bool ISearchTransactionRepository.Insert(SearchTransaction prSearchTransaction)
        {
            return base.Insert(prSearchTransaction);
        }

        bool ISearchTransactionRepository.Update(SearchTransaction prSearchTransaction)
        {
            return base.Update(prSearchTransaction);
        }

        bool ISearchTransactionRepository.Remove(SearchTransaction prSearchTransaction)
        {
            return base.Delete(prSearchTransaction);
        }
    }
}