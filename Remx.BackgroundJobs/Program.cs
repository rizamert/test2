using Remx.BackgroundJobs;
using Remx.Infrastructure;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddInfrastructure();
    })
    .Build();



host.Run();