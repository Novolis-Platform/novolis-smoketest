using Xunit; namespace Novolis.TemplateSmokeTest.Tests; public class SmokeTests { [Fact] public void Ping() => Assert.Equal("ok", TemplateSmokeTest.Smoke.Ping()); }
