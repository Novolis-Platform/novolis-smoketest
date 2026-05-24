namespace Novolis.TemplateSmokeTest;

/// <summary>
/// Smoke-test entry points for CI and NuGet validation.
/// </summary>
public static class Smoke
{
    /// <summary>
    /// Returns a fixed success token when the package loads correctly.
    /// </summary>
    /// <returns>The literal string <c>ok</c>.</returns>
    public static string Ping() => "ok";
}
