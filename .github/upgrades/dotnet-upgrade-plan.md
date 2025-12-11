# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade Tally.Web.Client.csproj
4. Upgrade Tally.Data.csproj
5. Upgrade Tally.Web.csproj
6. Upgrade Tally.Api.csproj
7. Upgrade Tally.Core.csproj

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.AspNetCore.Components.WebAssembly         |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.AspNetCore.Components.WebAssembly.Server  |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.AspNetCore.Identity.EntityFrameworkCore   |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.EntityFrameworkCore                      |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.EntityFrameworkCore.SqlServer            |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.EntityFrameworkCore.Tools                |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.Extensions.Configuration                |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.Extensions.Configuration.Json            |   9.0.9         |  10.0.1      | Recommended for .NET 10.0                |
| Microsoft.AspNetCore.OpenApi                       |   9.0.7         |  10.0.1      | Recommended for .NET 10.0                |

### Project upgrade details

#### Tally.Web.Client.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`
NuGet packages changes:
  - Microsoft.AspNetCore.Components.WebAssembly should be updated from `9.0.9` to `10.0.1`

#### Tally.Data.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`
NuGet packages changes:
  - Microsoft.EntityFrameworkCore should be updated from `9.0.9` to `10.0.1`
  - Microsoft.EntityFrameworkCore.SqlServer should be updated from `9.0.9` to `10.0.1`
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore should be updated from `9.0.9` to `10.0.1`
  - Microsoft.EntityFrameworkCore.Tools should be updated from `9.0.9` to `10.0.1`
  - Microsoft.Extensions.Configuration should be updated from `9.0.9` to `10.0.1`
  - Microsoft.Extensions.Configuration.Json should be updated from `9.0.9` to `10.0.1`

#### Tally.Web.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`
NuGet packages changes:
  - Microsoft.AspNetCore.Components.WebAssembly.Server should be updated from `9.0.9` to `10.0.1`

#### Tally.Api.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`
NuGet packages changes:
  - Microsoft.AspNetCore.OpenApi should be updated from `9.0.7` to `10.0.1`
  - Microsoft.EntityFrameworkCore.Tools should be updated from `9.0.9` to `10.0.1`

#### Tally.Core.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`
NuGet packages changes:
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore should be updated from `9.0.9` to `10.0.1`
  - Microsoft.EntityFrameworkCore.Tools should be updated from `9.0.9` to `10.0.1`
