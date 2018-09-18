using System;
using System.Collections.Generic;
using System.Text;

namespace Saga.Services
{
    public interface IBasketService
    {
        IEnumerable<Basket> GetAll();
    }

    
}
