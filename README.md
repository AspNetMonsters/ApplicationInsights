![Build status](https://github.com/AspNetMonsters/ApplicationInsights/workflows/Continuous%20Integration/badge.svg)

# ApplicationInsights
A collection of Telemetry Initializers to help you get the most out of Application Insights for .NET Core and ASP.NET Core apps

## ASP.NET Core

**Note:** Currently only supports ASP.NET Core 3.1 or greater

Install the Nuget Package
> dotnet add package AspNetMonsters.ApplicationInsights.AspNetCore

### Cloud Role Name Telemetry Initializer


In the `ConfigureServices` method in `Startup.cs`, call the `AddCloudRoleNameInitializer` method, passing in the cloud role name for the process.

For example:
```
  services.AddApplicationInsightsTelemetry();
  services.AddCloudRoleNameInitializer("PaymentService");
```

## .NET Core

Install the Nuget Package
> dotnet add package AspNetMonsters.ApplicationInsights

### Cloud Role Name Telemetry Initializer
// How to register the telemetry initializer
