using HealthKeeper.Models.Database;
using HealthKeeper.Models.Views;

namespace HealthKeeper.Utils
{
    public class StatisticValidator
    {
        private const double MinWeight = 0;
        private const double MaxWeight = 300;

        private const double MinHeight = 60;
        private const double MaxHeight = 300;

        public static (bool, string) Validate(double? weight, double? height)
        {

            if (weight == null)
            {
                return (true, "Das Gewicht muss angegeben werden.");
            }
            // Validate weight input
            if (weight <= MinWeight || weight >= MaxWeight)
            {
                return (true, $"Das angegebene Gewicht muss im Bereich von {MinWeight}kg bis {MaxWeight}kg liegen.");
            }

            // Check if a height could be determined.
            if (height == null)
            {
                return (true, "Die Größe muss angegeben werden.");
            }

            // Validate height input
            if (height <= MinHeight || height >= MaxHeight)
            {
                return (true, $"Die angegebene Größe muss im Bereich von {MinHeight}cm bis {MaxHeight}cm liegen.");
            }
            return (false, "");
        }
    }
}
