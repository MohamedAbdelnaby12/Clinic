using Clinic.BLL.Services.Abstract;
using Clinic.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<Receptionist> _userManager;

        public AuthService(UserManager<Receptionist> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> RegisterUser(string name, string email, string password)
        {
            var user = new Receptionist { Name = name, UserName = name, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }

        public async Task<bool> LoginUser(string name, string password)
        {
            var user = await _userManager.FindByNameAsync(name);
            if (user == null)
                return false;

            bool isPasswordValid = await _userManager.CheckPasswordAsync(user, password);
            return isPasswordValid;
        }
    }
}
