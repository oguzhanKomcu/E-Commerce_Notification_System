using ECNS.Application.Model.DTOs;
using ECNS.Application.Service.AppUserService;
using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECNS.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IAppUserService _userRepository;

        public UserController(IAppUserService userRepository)
        {
            _userRepository = userRepository;
        }


        /// <summary>
        /// This function lists all made user.
        /// </summary>
        /// <returns></returns>
        [Route("authenticate")]
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO user)
        {
            var token = _userRepository.Authentication(user.UserName, user.Password);
            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(new { token, user });

        }



        /// <summary>
        /// This function lists all made user.
        /// </summary>
        /// <returns></returns>
        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userRepository.GetUsers().ConfigureAwait(false));
        }

        /// <summary>
        /// This function returns the user whose "id" is given.
        /// </summary>
        /// <param name="id">It is a required area and so type is string</param>
        /// <returns>If function is succeded will be return Ok, than will be return NotFound</returns>

        [HttpGet("{id:length(24)}")]
        public IActionResult GetUser(string id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// You can add a new user using this method.
        /// </summary>
        /// <returns>If function is succeded will be return CreatedAtAction, than will be return Bad Request</returns>    
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO user)
        {
            if (user is null)
            {
                return BadRequest();
            }

            await _userRepository.Register(user);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }




    }
}
