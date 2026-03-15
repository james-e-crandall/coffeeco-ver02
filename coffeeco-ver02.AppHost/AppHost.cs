using System.Data.Common;
using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sqlserver");

var baseDb = sqlServer.AddDatabase("base-db");
var uiLibDb = sqlServer.AddDatabase("ui-lib-db");
var coffeeLibDb = sqlServer.AddDatabase("coffee-lib-db");

var uiLibMigrationService = builder.AddProject<Projects.UILib_MigrationService>("ui-lib-migration-service")
                            .WaitFor(uiLibDb)
                            .WithReference(uiLibDb);

var coffeeLibMigrationService = builder.AddProject<Projects.CoffeeLib_MigrationService>("coffee-lib-migration-service")
                            .WaitFor(coffeeLibDb)
                            .WithReference(coffeeLibDb);



var dab = builder.AddDataAPIBuilder("dab", ["dab-config.json", "dab-config.ui-lib-db.json", "dab-config.coffee-lib-db.json"])
            .WithReference(baseDb)
            .WithReference(uiLibDb)
            .WithReference(coffeeLibDb)
            .WaitFor(baseDb)
            .WaitFor(uiLibDb)
            .WaitFor(coffeeLibDb);

if(builder.Environment.IsDevelopment())
{
    var testWebsite = builder.AddJavaScriptApp("test-website", "../test-website", runScriptName: "start")
    .WithReference(dab)
    .WaitFor(dab)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();
}


var coffeeWebsite = builder.AddJavaScriptApp("coffee-website", "../coffee-website", runScriptName: "start")
    .WithReference(dab)
    .WaitFor(dab)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
