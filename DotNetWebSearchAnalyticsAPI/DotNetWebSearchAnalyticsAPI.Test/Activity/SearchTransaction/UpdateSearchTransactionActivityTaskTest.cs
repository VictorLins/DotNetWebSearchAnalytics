using DotNetWebSearchAnalyticsAPI.Data.Activity;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using Moq;

namespace DotNetWebSearchAnalyticsAPI.Test
{
    internal class UpdateSearchTransactionActivityTaskTest
    {
        [Test]
        public void Should_Update_Without_Error()
        {
            // Arrange
            var lSearchTransaction = new SearchTransaction();
            var lISearchTransactionRepository = new Mock<ISearchTransactionRepository>();

            UpdateSearchTransactionActivityTask lUpdateSearchTransactionActivityTask = new UpdateSearchTransactionActivityTask(lSearchTransaction, lISearchTransactionRepository.Object);

            // Act
            var lResult = lUpdateSearchTransactionActivityTask.Action();

            // Assert
            Assert.IsFalse(lResult);
        }
    }
}