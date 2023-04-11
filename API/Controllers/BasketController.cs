using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepos;
        public BasketController(IBasketRepository basketRepos)
        {
            _basketRepos = basketRepos;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetCustomerBasket(string id)
        {
            var basket = await _basketRepos.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
        {
            var updatedBasket = await _basketRepos.UpdateBasketAsync(basket);

            return Ok(updatedBasket);
        }
        [HttpDelete]
        public async Task DeletBasket(string id)
        { 
            await _basketRepos.DeleteBasketAsync(id);
        }

    }
}