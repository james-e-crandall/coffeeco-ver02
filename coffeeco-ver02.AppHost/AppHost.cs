var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sqlserver");
var uiLibDb = sqlServer.AddDatabase("ui-lib-db");
var coffeeLibDb = sqlServer.AddDatabase("coffee-lib-db");

var uiLibMigrationService = builder.AddProject<Projects.UILib_MigrationService>("ui-lib-migration-service")
                            .WaitFor(uiLibDb)
                            .WithReference(uiLibDb);

var coffeeLibMigrationService = builder.AddProject<Projects.CoffeeLib_MigrationService>("coffee-lib-migration-service")
                            .WaitFor(coffeeLibDb)
                            .WithReference(coffeeLibDb);

var coffeeWebsite = builder.AddJavaScriptApp("coffee-website", "../coffee-website", runScriptName: "start")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
