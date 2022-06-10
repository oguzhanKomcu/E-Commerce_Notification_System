using ECNS.Application.Model.DTOs;
using ECNS.Application.Service.CartService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECNS.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _carttService;
        public CartController(ICartService cartService)
        {
            _carttService = cartService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
        /// <returns>If function is succeded will be return CreatedAtAction, than will be return Bad Request</returns>        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CartDto cart)
        {
            if (cart is null)
            {
                return BadRequest();
            }

            await _carttService.Create(cart);
            
            return CreatedAtAction(nameof(GetById), new { id = cart.Id }, cart);
        }


        /// <summary>
        /// This function returns the cart whose "userid" is given.
        /// </summary>
        /// <param name="userId">It is a required area and so type is string</param>
        /// <returns>If function is succeded will be return Ok, than will be return NotFound</returns>
        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetById(string userId)
        {
            var product = await _carttService.GetById(userId);

            if (product is null)
            {
                return NotFound();
            }


            return Ok(product);


        }




        /// <summary>
        /// This function can remove your product. 
        /// </summary>
        /// <param name="id">It is a required area and so type is int</param>
        /// <returns>If function is succeded will be return NoContent, than will be return NotFound</returns>        
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string userId)
        {
            var cart = await _carttService.GetById(userId);

            if (cart is null)
            {
                return NotFound();
            }
            
            await _carttService.Delete(cart.User_Id);

            return NoContent();
        }

    }
}
