using Hangfire;
using Remx.Application.Attributes;
using Remx.Application.Base.BackgroundJobs;
using Serilog;

namespace Remx.BackgroundJobs.Jobs;

public class SampleJob : IRecurringJob
{
    [Queue("critical")]
    [RecurringJob("sample-job", "*/1 * * * *")]
    public void Execute()
    {
        Log.Information("HANGFIRE1 JOB EXECUTED");
        Log.Information("HANGFIRE1 JOB EXECUTED");
        Log.Information("HANGFIRE1 JOB EXECUTED");
        Log.Information("HANGFIRE1 JOB EXECUTED");   
    }
}
