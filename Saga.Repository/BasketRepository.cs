using System;
using System.Collections.Generic;
using System.Linq;

namespace Saga.Repository
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IBasketDataLoader basketDataLoader;

        private List<BasketDto> baskets;

        public BasketRepository(IBasketDataLoader basketDataLoader)
        {
            this.basketDataLoader = basketDataLoader;
            LoadBasketData();
        }


        public IEnumerable<BasketDto> GetAll()
        {
            return baskets;
        }

        public BasketDto GetByTransactionNumber(Guid transactionNumber)
        {
            return baskets.FirstOrDefault(x => x.TransactionNumber == transactionNumber);
        }

        private void LoadBasketData()
        {
            if (baskets == null)
            {
                baskets = this.basketDataLoader.LoadData().ToList() ;
            }

        }

    }
}
