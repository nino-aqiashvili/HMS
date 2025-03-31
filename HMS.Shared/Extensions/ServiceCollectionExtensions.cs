using HMS.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services, string jwtKey, string jwtIssuer, string jwtAudience)
        {
            services.AddSingleton(new JwtTokenGenerator(jwtKey, jwtIssuer, jwtAudience));
            return services;
        }
    }
}
