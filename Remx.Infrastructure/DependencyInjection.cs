using Microsoft.Extensions.DependencyInjection;
using Remx.Infrastructure.Excel;
using Remx.Infrastructure.MessageBus.Consumers;

namespace Remx.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<SampleMessageConsumer>();
        services.AddScoped<IExcelService, ExcelService>();

    }
}