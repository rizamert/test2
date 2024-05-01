using Hangfire;
using Remx.Application.Attributes;
using Remx.Application.Base.BackgroundJobs;
using Serilog;

namespace Remx.BackgroundJobs.Jobs;

public class SampleJob2 : IRecurringJob
{
    [Queue("default")]
    [RecurringJob("sample-job2", "*/1 * * * *")]
    public void Execute()
    {
        Log.Information("HANGFIRE2 JOB EXECUTED");
        Log.Information("HANGFIRE2 JOB EXECUTED");
        Log.Information("HANGFIRE2 JOB EXECUTED");
        Log.Information("HANGFIRE2 JOB EXECUTED");
        
    }
}
