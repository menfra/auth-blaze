using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace auth_blaze.Common
{
    public interface IAuthBlaze
    {
        Task<bool> AuthenticateAsync(string username, string password);
        Task<bool> EnforceMFAAsync(string username);
        bool IsGeolocationAllowed(HttpContext context);
        bool ValidateToken(string token);
    }
}
