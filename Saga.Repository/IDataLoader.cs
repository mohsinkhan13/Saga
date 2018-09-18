using System.Collections.Generic;

namespace Saga.Repository
{
    public interface IBasketDataLoader
    {
        IEnumerable<BasketDto> LoadData(); 
    }
}