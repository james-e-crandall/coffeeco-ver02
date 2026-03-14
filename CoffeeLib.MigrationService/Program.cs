using CoffeeLib.Data;
using CoffeeLib.MigrationService;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

builder.Services.AddDbContextPool<CoffeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("coffee-lib-db"), sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("CoffeeLib.MigrationService");
        }
    ));
builder.EnrichSqlServerDbContext<CoffeeContext>();

var host = builder.Build();
host.Run();
