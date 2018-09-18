using Microsoft.AspNetCore.Mvc;
using Saga.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saga.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BasketController : Controller
    {
        private readonly IBasketRepository repository;

        public BasketController(IBasketRepository basketRepository)
        {
            repository = basketRepository; 
        }

        public IActionResult Get()
        {
            var basketsDto = repository.GetAll();
            
            return Ok(new { item1 = "item1", item2 = "item2", item3 = "item3", item4 = "item4", });
        }
    }
}
