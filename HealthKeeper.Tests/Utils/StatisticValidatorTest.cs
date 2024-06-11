using HealthKeeper.Utils;

namespace HealthKeeper.Tests.Utils
{
    public class StatisticValidatorTest
    {

        [Test]
        public void TestValid()
        {
            Assert.That(StatisticValidator.Validate(30, 130).Item1, Is.EqualTo(false));
            Assert.That(StatisticValidator.Validate(30, 130).Item2, Is.EqualTo(""));
        }

        [Test]
        public void TestInvalid()
        {
            Assert.That(StatisticValidator.Validate(null, 130).Item2, Is.EqualTo("Das Gewicht muss angegeben werden."));
            Assert.That(StatisticValidator.Validate(null, 130).Item1, Is.EqualTo(true));

            Assert.That(StatisticValidator.Validate(90, null).Item2, Is.EqualTo("Die Größe muss angegeben werden."));
            Assert.That(StatisticValidator.Validate(90, null).Item1, Is.EqualTo(true));

            Assert.That(StatisticValidator.Validate(-42, 130).Item2, Is.EqualTo($"Das angegebene Gewicht muss im Bereich von 0kg bis 300kg liegen."));
            Assert.That(StatisticValidator.Validate(-42, 130).Item1, Is.EqualTo(true));
           
            Assert.That(StatisticValidator.Validate(502, 130).Item2, Is.EqualTo($"Das angegebene Gewicht muss im Bereich von 0kg bis 300kg liegen."));
            Assert.That(StatisticValidator.Validate(502, 130).Item1, Is.EqualTo(true));

            Assert.That(StatisticValidator.Validate(90, 42).Item2, Is.EqualTo($"Die angegebene Größe muss im Bereich von 60cm bis 300cm liegen."));
            Assert.That(StatisticValidator.Validate(90, 42).Item1, Is.EqualTo(true));

            Assert.That(StatisticValidator.Validate(90, 3130).Item2, Is.EqualTo($"Die angegebene Größe muss im Bereich von 60cm bis 300cm liegen."));
            Assert.That(StatisticValidator.Validate(90, 3130).Item1, Is.EqualTo(true));
        }
    }
}
