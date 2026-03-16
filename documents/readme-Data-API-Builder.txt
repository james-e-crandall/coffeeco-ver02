https://learn.microsoft.com/en-us/azure/data-api-builder/

https://learn.microsoft.com/en-us/azure/data-api-builder/configuration/


ERROR(S):
  Option 'h' is unknown.
  Required option 'database-type' is missing.

  --database-type                      Required. Type of database to connect. Supported values: mssql, cosmosdb_nosql, cosmosdb_postgresql, mysql, postgresql, dwsql

  --connection-string                  (Default: '') Connection details to connect to the database.

  --cosmosdb_nosql-database            Database name for Azure Cosmos DB for NoSql.

  --cosmosdb_nosql-container           Container name for Azure Cosmos DB for NoSql.

  --graphql-schema                     GraphQL schema Path.

  --set-session-context                (Default: false) Enable sending data to MsSql using session context.

  --host-mode                          (Default: Production) Specify the Host mode - Development or Production

  --cors-origin                        Specify the list of allowed origins.

  --auth.provider                      (Default: AppService) Specify the Identity Provider.

  --auth.audience                      Identifies the recipients that the JWT is intended for.

  --auth.issuer                        Specify the party that issued the jwt token.

  --rest.path                          (Default: /api) Specify the REST endpoint's default prefix.

  --runtime.base-route                 Specifies the base route for API requests.

  --rest.disabled                      (Default: false) Disables REST endpoint for all entities.

  --graphql.path                       (Default: /graphql) Specify the GraphQL endpoint's default prefix.

  --graphql.disabled                   (Default: false) Disables GraphQL endpoint for all entities.

  --mcp.path                           (Default: /mcp) Specify the MCP endpoint's default prefix.

  --mcp.disabled                       (Default: false) Disables MCP endpoint for all entities.

  --rest.enabled                       (Default: true) Enables REST endpoint for all entities. Supported values: true, false.

  --graphql.enabled                    (Default: true) Enables GraphQL endpoint for all entities. Supported values: true, false.

  --mcp.enabled                        (Default: true) Enables MCP endpoint for all entities. Supported values: true, false.

  --rest.request-body-strict           (Default: true) Allow extraneous fields in the request body for REST.

  --graphql.multiple-create.enabled    (Default: false) Enables multiple create operation for GraphQL. Supported values: true, false.

  -c, --config                         Path to config file. Defaults to 'dab-config.json' unless 'dab-config.<DAB_ENVIRONMENT>.json' exists, where DAB_ENVIRONMENT is an environment
                                       variable.

  --help                               Display this help screen.

  --version                            Display version information.


To Create File:

dab init --database-type "mssql" --connection-string "@env('ConnectionStrings__base_db')" --host-mode "Development"

dab init --database-type "mssql" --connection-string "@env('ConnectionStrings__ui_lib_db')" --host-mode "Development" -c "dab-config.ui-lib-db.json"

dab init --database-type "mssql" --connection-string "@env('ConnectionStrings__coffee_lib_db')" --host-mode "Development" -c "dab-config.coffee-lib-db.json"

add:
    "health": {
      "enabled": true,
      "cache-ttl-seconds": 5,
      "roles": [
        "anonymous"
      ],
      "max-query-parallelism": 4
    }

https://learn.microsoft.com/en-us/azure/data-api-builder/concept/security/how-to-authenticate-custom?tabs=bash

migration:

dab add HomeList --source "HomeList" --permissions "Anonymous:read" -c "dab-config.ui-lib-db.json"

dab add HomeRow --source "HomeRow" --permissions "Anonymous:read" -c "dab-config.ui-lib-db.json"

dab add HomeItem --source "HomeItem" --permissions "Anonymous:read" -c "dab-config.ui-lib-db.json"

dab update HomeList --relationship HomeRows --target.entity HomeRow --cardinality many -c "dab-config.ui-lib-db.json"

dab update HomeRow --relationship HomeItems --target.entity HomeItem --cardinality many -c "dab-config.ui-lib-db.json"

migration:

dab add HomeItemType --source "HomeItemTypes" --permissions "Anonymous:read" -c "dab-config.ui-lib-db.json"

migration:

dab add HomeRowType --source "HomeRowTypes" --permissions "Anonymous:read" -c "dab-config.ui-lib-db.json"

