using ECNS.Application.Model.DTOs;
using ECNS.Application.Service.CartService;
using ECNS.Application.Service.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECNS.Api.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _carttService;
        private readonly IProductService _productService;
        public CartController(ICartService cartService, IProductService productService)
        {
            _carttService = cartService;
            _productService = productService;
        }



        /// <summary>
        /// You can add a new cart using this method.
        /// </summary>
        ///  <param name="cart">It is a required area and so type is model</param>
        /// <returns>If function is succeded will be return CreatedAtAction, than will be return Bad Request</returns>        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CartDto cart)
        {

            if (ModelState.IsValid)
            {
                var product = await _productService.GetById(cart.Product_Id);
                if (product.Stock >= cart.Quantity)
                {

                    await _carttService.Create(cart);

                    return Ok(cart);
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "The quantity you want to select is more than the current stock status..!");
                    return BadRequest(ModelState);
                }

            }
            else
            {
                return BadRequest(String.Join(Environment.NewLine, ModelState.Values.SelectMany(h => h.Errors).Select(h => h.ErrorMessage + "" + h.Exception)));
            }
            
        

        }


        /// <summary>
        /// This function returns the cart whose "userid" is given.
        /// </summary>
        /// <param name="userId">It is a required area and so type is string</param>
        /// <returns>If function is succeded will be return Ok, than will be return NotFound</returns>
        [HttpGet("{userId:string}")]
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
        /// This function can remove your cart. 
        /// </summary>
        /// <param name="userId">It is a required area and so type is int</param>
        /// <returns>If function is succeded will be return NoContent, than will be return NotFound</returns>        
        [HttpDelete("{userId:string}")]
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
