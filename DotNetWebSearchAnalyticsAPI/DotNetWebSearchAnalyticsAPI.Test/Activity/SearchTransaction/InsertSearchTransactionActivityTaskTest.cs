using DotNetWebSearchAnalyticsAPI.Data.Activity;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using Moq;

namespace DotNetWebSearchAnalyticsAPI.Test
{
    internal class InsertSearchTransactionActivityTaskTest
    {
        [Test]
        public void Should_Insert_Without_Error()
        {
            // Arrange
            var lSearchTransaction = new SearchTransaction();
            var lISearchTransactionRepository = new Mock<ISearchTransactionRepository>();

            InsertSearchTransactionActivityTask lInsertSearchTransactionActivityTask = new InsertSearchTransactionActivityTask(lSearchTransaction, lISearchTransactionRepository.Object);

            // Act
            var lResult = lInsertSearchTransactionActivityTask.Action();

            // Assert
            Assert.IsFalse(lResult);
        }
    }
}