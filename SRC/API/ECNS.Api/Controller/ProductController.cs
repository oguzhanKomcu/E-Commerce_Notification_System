using ECNS.Application.Model.DTOs;
using ECNS.Application.Notifications;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICartService _carttService;




        public ProductController(IProductService productService, ICartService carttService)
        {
            _productService = productService;
            _carttService = carttService;
           
        }




        /// <summary>
        /// This function lists all made products.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productService.GetProducts());
        }





        /// <summary>
        /// This function returns the product whose "id" is given.
        /// </summary>
        /// <param name="id">It is a required area and so type is string</param>
        /// <returns>If function is succeded will be return Ok, than will be return NotFound</returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetById(id);

            if (product is null)
            {
                return NotFound();
            }


            return Ok(product);


        }

        /// <summary>
        /// You can add a new product using this method.
        /// </summary>
        ///  <param name="product">It is a required area and so type is product</param>
        /// <returns>If function is succeded will be return CreatedAtAction, than will be return Bad Request</returns>        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDTO product)
        {




            if (ModelState.IsValid)
            {

                await _productService.Create(product);

                return Ok(product);
            }
            else
            {
                return BadRequest(String.Join(Environment.NewLine, ModelState.Values.SelectMany(h => h.Errors).Select(h => h.ErrorMessage + "" + h.Exception)));
            }


        }

        /// <summary>
        /// Using this method, you can edit and update the product whose "id" is specified.
        /// </summary>
        /// <param name="product">It is a required area and so type is int</param>
        /// <returns>If function is succeded will be return NoContent, than will be return Bad Request</returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductDTO product)
        {

            if (product.Price != null)
            {
               var users =  await _carttService.GetProductByUsers(product.Id);

                foreach (var item in users)
                {
                    var user = users.Select(x => x.Product_Price == product.Price).FirstOrDefault();

                    if (user != true)
                    {
                       
                        
                        if (users.Select(x => x.Product_Price > product.Price || x.Product_Price < product.Price).FirstOrDefault())
                        {
                            ProductNotifications productNotifications = new ProductNotifications();
                            productNotifications.Subscribe(new UserNotifications(item.UserName , product.Price, item.UserEmail));
                            productNotifications.ProductPrice = true;
                        }
                    }

                }
               


            }


            var existingProduct = await _productService.GetById(product.Id);


            
            
            if (existingProduct is null)
            {
                return BadRequest();
            }

            await _productService.Update(product);

            return NoContent();
        }


        /// <summary>
        /// This function can remove your product. 
        /// </summary>
        /// <param name="productId">It is a required area and so type is int</param>
        /// <returns>If function is succeded will be return NoContent, than will be return NotFound</returns>        
        [HttpDelete("{productId:int}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var customer = await _productService.GetById(productId);

            if (customer is null)
            {
                return NotFound();
            }

            await _productService.Delete(customer.Id);

            return NoContent();
        }
        
          

    }
}

