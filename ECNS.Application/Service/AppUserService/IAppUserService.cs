using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using ECNS.Domainn.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Service.AppUserService
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task<SignInResult> Login(LoginDTO model);
        Task LogOut();
        Task<AppUser>  Authentication(string userName, string password);
        Task<List<GetAppUserVm>> GetUsers();
        bool IsUniqeuUser(string userName);
        Task UpdateUser(UpdateProfileDTO model);

        Task<UpdateProfileDTO> GetById(string id);
    }
}
