using Microsoft.EntityFrameworkCore;
using UILib.Data;
using UILib.MigrationService;

var builder = Host.CreateApplicationBuilder(args);
builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

builder.Services.AddDbContextPool<UIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ui-lib-db"), sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("UILib.MigrationService");
        }
    ));
builder.EnrichSqlServerDbContext<UIContext>();

var host = builder.Build();
host.Run();
