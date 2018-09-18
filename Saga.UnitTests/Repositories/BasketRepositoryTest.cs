using Microsoft.VisualStudio.TestTools.UnitTesting;
using Saga.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.UnitTests.Repositories
{
    [TestClass]
    public class BasketRepositoryTest
    {
        private readonly IBasketDataLoader dataLoader;
        private readonly BasketRepository repository;

        public BasketRepositoryTest()
        {
            dataLoader = new InMemoryBasketDataLoader();
            repository = new BasketRepository(dataLoader);
        }

        [TestMethod]
        public void GetAll_ReturnsListOf5Baskets()
        {
            var expectedCount = 5;
            var result = repository.GetAll().ToList();

            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void GetByTransactionNumber_ReturnsMatchingBasket()
        {
            var transactionNumber = new Guid("0002b3be-4f0b-418a-b7dd-670494981a89");
            var result = repository.GetByTransactionNumber(transactionNumber);

            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void GetAll_ReturnsListOrderedByCreatedDateTime()
        //{
        //    var expectedList = repository.GetAll().OrderByDescending(x => x.CreatedDataTime);
        //    var result = repository.GetAll().ToList();

        //    Assert.IsTrue(expectedList.SequenceEqual(result));
        //}

    }
}
