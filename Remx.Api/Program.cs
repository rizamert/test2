using Remx.Api.Configurations;
using Remx.Api.Middlewares;
using Remx.Application;
using Remx.Infrastructure;
using Remx.Infrastructure.ApiDocumentation;
using Remx.Infrastructure.Ef;
using Remx.Infrastructure.Logging;
using Remx.Infrastructure.MessageBus.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Configure Serilog
builder.Services.AddRemLogging(configuration.GetConnectionString("SqlServer"));

builder.Host.UseSerilog();

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });


builder.Services.AddControllers();

builder.Services.AddCustomCors();

var rabbitMqConfig = configuration.GetSection("RabbitMQ");
builder.Services.ConfigureMassTransit(rabbitMqConfig["Url"]);

builder.Services.AddApplication();
builder.Services.AddInfrastructureEf(configuration.GetConnectionString("SqlServer"));

builder.Services.AddInfrastructure();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRemSwagger();

// builder.Services.AddRemAuthentication(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("AllowAllOrigins");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();