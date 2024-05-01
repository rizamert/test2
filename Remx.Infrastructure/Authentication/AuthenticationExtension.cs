using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Remx.Infrastructure.Authentication;

public static class AuthenticationExtension
{
    public static IServiceCollection AddRemAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,options =>
            {
                options.Authority = "https://rem-idserver.azurewebsites.net/";
                options.RequireHttpsMetadata = false;
                options.Audience = "REM.POI.CatalogAPI";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

        return services;
    }
}