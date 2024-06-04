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
                return "Severe Thinness";
            case < 17.0:
                return "Moderate Thinness";
            case < 18.5:
                return "Mild Thinness";
            case < 25.0:
                return "Normal";
            case < 30.0:
                return "Overweight";
            case < 35.0:
                return "Obese Class I";
            case < 40.0:
                return "Obese Class II";
            default:
                return "Obese Class III";
        }
    }
}