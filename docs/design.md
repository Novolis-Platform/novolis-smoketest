# Design

## Purpose

This repository exists to exercise the Novolis package pipeline end-to-end: pack, symbol publish, and consumer restore. It is not a gameplay or infrastructure library.

## Package surface

| Package | Role |
|---------|------|
| `Novolis.TemplateSmokeTest` | Returns a fixed `"ok"` string from `Smoke.Ping()` for health checks |

## Constraints

- No external runtime dependencies beyond the .NET SDK
- Public API kept minimal so CI stays fast and documentation stays complete under strict `CS1591`
