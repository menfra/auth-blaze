using auth_blaze.Common;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace auth_blaze.Configuration
{
    public static class AuthBlazeExtensions
    {
        public static IApplicationBuilder UseAuthBlaze(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthBlazeMiddleware>();
        }
    }
}
