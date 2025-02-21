using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.BLL.Services.Abstract
{
    public interface IAuthService
    {
        public  Task<bool> RegisterUser(string name, string email, string password);
        public Task<bool> LoginUser(string name, string password);
        public Task<bool> CheckAdminRole(string userName);
    }
}
