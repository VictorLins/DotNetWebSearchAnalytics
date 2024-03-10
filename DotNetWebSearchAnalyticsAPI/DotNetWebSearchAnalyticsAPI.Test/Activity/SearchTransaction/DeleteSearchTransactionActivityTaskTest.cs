using DotNetWebSearchAnalyticsAPI.Data.Activity;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using Moq;

namespace DotNetWebSearchAnalyticsAPI.Test
{
    internal class DeleteSearchTransactionActivityTaskTest
    {
        [Test]
        public void Should_Delete_Without_Error()
        {
            // Arrange
            var lSearchTransaction = new SearchTransaction();
            var lISearchTransactionRepository = new Mock<ISearchTransactionRepository>();

            DeleteSearchTransactionActivityTask lDeleteSearchTransactionActivityTask = new DeleteSearchTransactionActivityTask(lSearchTransaction, lISearchTransactionRepository.Object);

            // Act
            var lResult = lDeleteSearchTransactionActivityTask.Action();

            // Assert
            Assert.IsFalse(lResult);
        }
    }
}