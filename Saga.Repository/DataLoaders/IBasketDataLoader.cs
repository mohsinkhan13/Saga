using System;
using System.Collections.Generic;

namespace Saga.Repository
{
    public interface IBasketDataLoader
    {
        IEnumerable<BasketDto> LoadData(); 
    }

    public class InMemoryBasketDataLoader : IBasketDataLoader
    {
        public IEnumerable<BasketDto> LoadData()
        {
            return new List<BasketDto>
            {
                new BasketDto{TransactionNumber= new Guid("0002b3be-4f0b-418a-b7dd-670494981a89"),Domain = 1,CreatedDataTime = DateTime.Today.AddDays(-2)},
                new BasketDto{TransactionNumber=Guid.NewGuid(),Domain = 2,CreatedDataTime = DateTime.Today.AddDays(-1)},
                new BasketDto{TransactionNumber=Guid.NewGuid(),Domain = 3,CreatedDataTime = DateTime.Today.AddDays(-3)},
                new BasketDto{TransactionNumber=Guid.NewGuid(),Domain = 4,CreatedDataTime = DateTime.Today.AddDays(-5)},
                new BasketDto{TransactionNumber=Guid.NewGuid(),Domain = 5,CreatedDataTime = DateTime.Today.AddDays(-8)},
            };
        }
    }
}