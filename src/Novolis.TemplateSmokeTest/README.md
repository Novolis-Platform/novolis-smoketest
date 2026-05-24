# Novolis.TemplateSmokeTest

Minimal packable library used to validate NuGet publishing and CI smoke workflows.

## Install

```bash
dotnet add package Novolis.TemplateSmokeTest
```

**Prerequisites:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (`net10.0`).

## Quick start

```csharp
using Novolis.TemplateSmokeTest;

Console.WriteLine(Smoke.Ping()); // "ok"
```

## Related packages

| Package | When to use |
|---------|-------------|
| *(none)* | Standalone smoke-test helper; not a runtime dependency for apps. |

## More documentation

- [Getting started](https://github.com/Novolis-Platform/novolis-smoketest/blob/main/docs/getting-started.md)
- [Design](https://github.com/Novolis-Platform/novolis-smoketest/blob/main/docs/design.md)

## Support

Pre-release smoke package for platform CI; API surface is intentionally tiny and stable.
