using API.DTOs;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepos;
        private readonly IMapper _mapper;

        public BasketController(IBasketRepository basketRepos, IMapper mapper)
        {
            _basketRepos = basketRepos;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetCustomerBasket(string id)
        {
            var basket = await _basketRepos.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasket>(basket);
            var updatedBasket = await _basketRepos.UpdateBasketAsync(customerBasket);

            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeletBasket(string id)
        {
            await _basketRepos.DeleteBasketAsync(id);
        }
    }
}