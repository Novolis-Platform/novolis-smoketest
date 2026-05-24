# Release

## Versioning

Versions follow `build/version.json` and shared Novolis versioning targets imported from `novolis-governance`.

## Publishing

1. Merge to `main` with a green `dotnet build` on `Novolis.Smoketest.sln`
2. CI packs `Novolis.TemplateSmokeTest` to GitHub Packages (org feed)
3. Downstream workflows may reference this package to confirm feed connectivity

## Package contents

Each release includes the assembly, XML documentation, symbols (`snupkg`), and the package README under `src/Novolis.TemplateSmokeTest/README.md`.
