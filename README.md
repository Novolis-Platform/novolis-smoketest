<!-- novolis-marketing:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-brand-transparent.svg" width="360" alt="Novolis"/>
  </a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/banners/novolis-smoketest.svg" width="100%" alt="novolis-smoketest"/>
</p>

<p align="center">
  <strong>Template smoke package</strong><br/>
  Smoke-test package proving the template/publish pipeline.
</p>

<p align="center">
  <a href="https://github.com/Novolis-Platform/novolis-smoketest/actions"><img src="https://img.shields.io/github/actions/workflow/status/Novolis-Platform/novolis-smoketest/merge.yml?branch=main&label=merge&logo=github" alt="merge"/></a>
  <a href="https://github.com/orgs/Novolis-Platform/packages?repo_name=novolis-smoketest"><img src="https://img.shields.io/badge/packages-GitHub%20Packages-0a7ea3?logo=nuget" alt="packages"/></a>
  <a href="https://github.com/Novolis-Platform"><img src="https://img.shields.io/badge/org-Novolis--Platform-111827" alt="org"/></a>
</p>

<p align="center">
  <a href="https://nuget.pkg.github.com/Novolis-Platform/index.json"><code>https://nuget.pkg.github.com/Novolis-Platform/index.json</code></a>
  ·
  <a href="https://github.com/Novolis-Platform/.github/blob/main/profile/README.md">Org landing</a>
  ·
  <a href="https://github.com/Novolis-Platform/novolis-governance">Governance</a>
</p>

---
<!-- novolis-marketing:end -->
<!-- novolis-package-index:start -->
> **GitHub Packages shows this repository README on every package page** (upstream limitation).
> Open the **package README** for install and quick start — embedded in each .nupkg and linked below.

## Published packages

| Package | Install | Package README |
|---------|---------|----------------|
| `Novolis.TemplateSmokeTest` | `dotnet add package Novolis.TemplateSmokeTest` | [README](https://github.com/Novolis-Platform/novolis-smoketest/blob/main/src/Novolis.TemplateSmokeTest/README.md) |

For NuGet.org and Visual Studio, the **embedded** README.md inside each package is authoritative.

<!-- novolis-package-index:end -->
# novolis-smoketest

Minimal packable library used to validate NuGet publishing and CI smoke workflows across the platform.

## Package

| Package | Description |
|---------|-------------|
| [Novolis.TemplateSmokeTest](src/Novolis.TemplateSmokeTest/README.md) | Tiny API (`Smoke.Ping()`) for pipeline verification |

## Current status

Bootstrap / active development — intentionally small surface for merge and release workflow tests.

## Install

```bash
dotnet add package Novolis.TemplateSmokeTest
```

Packages publish to **GitHub Packages** (`2026.1.*`) and **nuget.org**. Use **`Novolis.Platform.slnx`** for local ProjectReference iteration on dependent repos.

## Quick start

```csharp
using Novolis.TemplateSmokeTest;

Console.WriteLine(Smoke.Ping()); // "ok"
```

## Documentation

- [Getting started](docs/getting-started.md)
- [Design](docs/design.md)
- [Release](docs/release.md)

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md).

## Security

See [SECURITY.md](SECURITY.md).

