# Getting started

`novolis-smoketest` ships a single packable library, **Novolis.TemplateSmokeTest**, used to verify NuGet packaging and CI pipelines across the Novolis platform.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Build

```bash
dotnet build Novolis.Smoketest.sln
```

## Use the package

```bash
dotnet add package Novolis.TemplateSmokeTest
```

```csharp
using Novolis.TemplateSmokeTest;

Console.WriteLine(Smoke.Ping());
```

## See also

- [Design](design.md) — purpose and scope
- [Release](release.md) — versioning and publishing
