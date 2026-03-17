using Microsoft.EntityFrameworkCore;
using UILib.Data;
using UILib.MigrationService;
using UILib.Models;

var builder = Host.CreateApplicationBuilder(args);
builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

builder.Services.AddOpenTelemetry()
    .WithTracing(tracing => tracing.AddSource(Worker.ActivitySourceName));

builder.Services.AddDbContextPool<UIContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("ui-lib-db"), sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly("UILib.MigrationService");
                }
            );

        options.UseSeeding((context, _) =>
        {
            var SimpleImage = context.Set<HomeRowType>().FirstOrDefault(b => b.Type == "SimpleImage");
            if (SimpleImage == null)
            {
                context.Set<HomeRowType>().Add(new HomeRowType { Type = "SimpleImage" });
                context.SaveChanges();
            }
            var SimpleMessage = context.Set<HomeRowType>().FirstOrDefault(b => b.Type == "SimpleMessage");
            if (SimpleMessage == null)
            {
                context.Set<HomeRowType>().Add(new HomeRowType { Type = "SimpleMessage" });
                context.SaveChanges();
            }
        })
        .UseAsyncSeeding(async (context, _, cancellationToken) =>
        {
            var HomeContent = await context.Set<HomeContent>().FirstOrDefaultAsync(b => b.Id == 1);

            var SimpleMessageHomeRowType = await context.Set<HomeRowType>().FirstOrDefaultAsync(b => b.Type == "SimpleMessage");
            if (SimpleMessageHomeRowType == null)
            {
                SimpleMessageHomeRowType = new HomeRowType { Type = "SimpleMessage" };
                context.Set<HomeRowType>().Add(SimpleMessageHomeRowType);
                await context.SaveChangesAsync();
            }
            var SimpleImageHomeRowType = await context.Set<HomeRowType>().FirstOrDefaultAsync(b => b.Type == "SimpleImage");
            if (SimpleImageHomeRowType == null)
            {
                SimpleImageHomeRowType = new HomeRowType { Type = "SimpleImage" };
                context.Set<HomeRowType>().Add(SimpleImageHomeRowType);
                await context.SaveChangesAsync();
            }

            var SimpleMessageHomeRow = await context.Set<HomeRow>().FirstOrDefaultAsync(b => b.HomeRowTypeId == SimpleMessageHomeRowType.Id);
            if (SimpleMessageHomeRow == null)
            {
                SimpleMessageHomeRow = new HomeRow { HomeRowTypeId = SimpleMessageHomeRowType.Id, HomeContentId = HomeContent.Id };
                context.Set<HomeRow>().Add(SimpleMessageHomeRow);
                await context.SaveChangesAsync();
                var SimpleImageHomeItem = new HomeItem { Id = 1, Value="Hello World", HomeRowId = SimpleMessageHomeRow.Id };
                await context.SaveChangesAsync();
            }

            var SimpleImageHomeRow = await context.Set<HomeRow>().FirstOrDefaultAsync(b => b.HomeRowTypeId == SimpleImageHomeRowType.Id);
            if (SimpleImageHomeRowType == null)
            {
                SimpleImageHomeRow = new HomeRow { HomeRowTypeId = SimpleImageHomeRowType.Id, HomeContentId = HomeContent.Id };
                context.Set<HomeRow>().Add(SimpleImageHomeRow);
                await context.SaveChangesAsync();
                var SimpleImageHomeItem = new HomeItem { Id = 1, Value="Hello World", HomeRowId = SimpleImageHomeRow.Id };
                await context.SaveChangesAsync();
            }


        });

    });

builder.EnrichSqlServerDbContext<UIContext>();

var host = builder.Build();
host.Run();
