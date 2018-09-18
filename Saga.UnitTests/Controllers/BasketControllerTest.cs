using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Saga.Repository;
using Saga.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saga.UnitTests.Controllers
{
    [TestClass]
    public class BasketControllerTest
    {
        private readonly BasketRepository repository;
        private readonly BasketController controller;

        public BasketControllerTest()
        {
            repository = new BasketRepository(new InMemoryBasketDataLoader());
            controller = new BasketController(repository);
        }
        [TestMethod]
        public void Get_Returns_OkResult()
        {
            var result = controller.Get();
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Get_Returns_ListOfBaskets()
        {
            var result = controller.Get();
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

    }
}
