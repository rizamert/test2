using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Remx.Domain.Repositories;
using Remx.Domain.UnitOfWork;
using Remx.Infrastructure.Ef.Base;
using Remx.Infrastructure.Ef.Contexts;

namespace Remx.Infrastructure.Ef;

public static class DependencyInjection
{
    public static void AddInfrastructureEf(this IServiceCollection services, string connectionString)
    {
        
        if (string.IsNullOrEmpty(connectionString)) 
            return;

        services.AddScoped(typeof(IRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

        
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString,
                x=>x.UseNetTopologySuite()));
    }
}