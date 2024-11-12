using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace auth_blaze.Common
{
    public class AuthBlazeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IAuthBlaze _authBlaze;

        public AuthBlazeMiddleware(RequestDelegate next, IAuthBlaze authBlaze)
        {
            _next = next;
            _authBlaze = authBlaze;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!_authBlaze.IsGeolocationAllowed(context))
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Access denied based on geolocation.");
                return;
            }

            await _next(context); // Continue processing the request if checks pass
        }
    }
}
