using TUnit.Core;

namespace Novolis.TemplateSmokeTest.Tests;

public class SmokeTests
{
    [Test]
    public async Task Ping()
    {
        await Assert.That(TemplateSmokeTest.Smoke.Ping()).IsEqualTo("ok");
    }
}
