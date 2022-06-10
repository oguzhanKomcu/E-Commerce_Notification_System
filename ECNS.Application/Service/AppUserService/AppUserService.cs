using AutoMapper;
using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.UoW;
using ECNS.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace ECNS.Application.Service.AppUserService
{
    public class AppUserService : IAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public AppUser Authentication(string userName, string password)
        {
            var user = _context.AppUsers.SingleOrDefault(x => x.UserName == userName &&
                                                              x.PasswordHash == password);

            if (user == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_context.SecretKey);
                var tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                        new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                user.Token = tokenHandler.WriteToken(token);

                return user;
            }
        }

        public async Task<UpdateProfileDTO> GetById(string id)
        {
            GetAppUserVm user = await _unitOfWork.UserRepository.GetFilteredFirstOrDefault(
                selector: x => new GetAppUserVm
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                },
                expression: x => x.Id == id &&
                                x.Status != Status.Passive);

            UpdateProfileDTO model = _mapper.Map<UpdateProfileDTO>(user);

            return model;
        }

        public bool IsUniqeuUser(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<SignInResult> Login(LoginDTO model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            return result;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO model)
        {
            var user = _mapper.Map<AppUser>(model);

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
            }

            return result;
        }

        public async Task<List<GetAppUserVm>> GetUsers()
        {
            var users = await _unitOfWork.UserRepository.GetFilteredList(
               selector: x => new GetAppUserVm
               {
                   Id = x.Id,
                   UserName = x.UserName,
                   Email = x.Email,

               },
               expression: x => x.Status != Status.Passive,
               orderBy: x => x.OrderBy(x => x.UserName));

            return users;
        }

        public async Task UpdateUser(UpdateProfileDTO model)
        {
            var user = await _unitOfWork.UserRepository.GetDefault(x => x.Id == model.Id);

            if (user != null)
            {
                if (model.UploadPath != null)
                {
                    using var image = Image.Load(model.UploadPath.OpenReadStream());
                    image.Mutate(x => x.Resize(256, 256));
                    string guid = Guid.NewGuid().ToString();
                    image.Save($"wwwroot/images/user/{guid}.jpg");
                    user.ImagePath = $"/images/user/{guid}.jpg";

                    if (model.UserName != null)
                    {
                        await _userManager.SetUserNameAsync(user, model.UserName);
                        await _signInManager.SignInAsync(user, false);
                    }

                    if (model.Email != null)
                    {
                        await _userManager.SetEmailAsync(user, model.Email);
                    }

                    if (model.Password != null)
                    {
                        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                        await _userManager.UpdateAsync(user);
                    }
                }
            }
        }
    }
}
