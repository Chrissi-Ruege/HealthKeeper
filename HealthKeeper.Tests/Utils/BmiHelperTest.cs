using HealthKeeper.Utils;

namespace HealthKeeper.Tests.Utils;

public class BmiHelperTest
{

    [Test]
    public void TestCalculateBmi()
    {
        Assert.That(BmiHelper.CalculateBMI(80, 80), Is.EqualTo(0.0125));
    }

    [Test]
    public void TestBmiToText()
    {
        Assert.That(BmiHelper.BmiToText(0), Is.EqualTo("starkes Untergewicht"));
        Assert.That(BmiHelper.BmiToText(16.4), Is.EqualTo("mäßiges Untergewicht"));
        Assert.That(BmiHelper.BmiToText(18.4), Is.EqualTo("leichtes Untergewicht"));
        Assert.That(BmiHelper.BmiToText(24), Is.EqualTo("Normalgewicht"));
        Assert.That(BmiHelper.BmiToText(100), Is.EqualTo("Adipositas Grad III"));
        Assert.That(BmiHelper.BmiToText(36), Is.EqualTo("Adipositas Grad II"));
        Assert.That(BmiHelper.BmiToText(30.99), Is.EqualTo("Adipositas Grad I"));
        Assert.That(BmiHelper.BmiToText(25), Is.EqualTo("Präadipositas"));
    }
}