using Hangfire;
using Remx.Application.Attributes;
using Remx.Application.Base.BackgroundJobs;
using Serilog;

namespace Remx.BackgroundJobs.Jobs;

public class SampleJob3 : IRecurringJob
{
    [Queue("default")]
    [RecurringJob("sample-job3", "*/1 * * * *")]
    public void Execute()
    {
        Log.Information("HANGFIRE3 JOB EXECUTED");
        Log.Information("HANGFIRE3 JOB EXECUTED");
        Log.Information("HANGFIRE3 JOB EXECUTED");
        Log.Information("HANGFIRE3 JOB EXECUTED");
        
    }
}
