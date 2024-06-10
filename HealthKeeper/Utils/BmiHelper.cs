namespace HealthKeeper.Utils;

public static class BmiHelper
{
    /// <summary>
    /// Calculates the bmi value from the height and weight of a person.
    /// </summary>
    /// <param name="weight">The current weight in kilogram.</param>
    /// <param name="height">The current height in meter.</param>
    /// <returns>Returns the calculated bmi value.</returns>
    public static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    /// <summary>
    /// Returns the corresponding bmi category from a given bmi value.
    /// </summary>
    /// <see cref="https://www.calculator.net/bmi-calculator.html"/>
    /// <param name="bmi">BMI value</param>
    /// <returns>The name of the category</returns>
    public static string BmiToText(double bmi)
    {
        switch (bmi)
        {
            case < 16.0:
                return "starkes Untergewicht";
            case < 17.0:
                return "mäßiges Untergewicht";
            case < 18.5:
                return "leichtes Untergewicht";
            case < 25.0:
                return "Normalgewicht";
            case < 30.0:
                return "Präadipositas";
            case < 35.0:
                return "Adipositas Grad I";
            case < 40.0:
                return "Adipositas Grad II";
            default:
                return "Adipositas Grad III";
        }
    }
}