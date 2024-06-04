using HealthKeeper.Utils;

namespace HealthKeeper.Tests.Utils;

public class BmiHelperTest
{
    [Test]
    public void TestBmiToText()
    {
        Assert.That(BmiHelper.BmiToText(0), Is.EqualTo("Severe Thinness"));
        Assert.That(BmiHelper.BmiToText(100), Is.EqualTo("Obese Class III"));
        Assert.That(BmiHelper.BmiToText(39.99), Is.EqualTo("Obese Class II"));
        Assert.That(BmiHelper.BmiToText(25), Is.EqualTo("Overweight"));
    }
}