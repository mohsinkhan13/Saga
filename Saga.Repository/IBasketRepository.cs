using System;
using System.Collections.Generic;
using System.Text;

namespace Saga.Repository
{
    public interface IBasketRepository
    {
        IEnumerable<BasketDto> GetAll();
        BasketDto GetByTransactionNumber(Guid transactionNumber);
    }
}
