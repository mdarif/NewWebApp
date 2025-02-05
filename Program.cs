/// <summary>
/// Demonstrates the differences between double and decimal numeric types in C#,
/// including division operations and value ranges.
/// </summary>

// Double division demonstration
// Shows how double handles division with potential infinite decimal places
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);  // Outputs approximate value with double precision

// Decimal division demonstration
// Shows how decimal handles division with higher precision for financial calculations
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);  // Outputs more precise decimal value

// Decimal range demonstration
// Shows the minimum and maximum values that can be stored in a decimal type
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

/// <summary>
/// Calculates the area of a circle using the formula A = πr²
/// </summary>

// Define the radius in centimeters
double radius = 2.50;

// Calculate the area using Math.PI and Math.Pow
double area = Math.PI * Math.Pow(radius, 2);

// Display the result with 2 decimal places
Console.WriteLine($"The area of a circle with radius {radius:F2} cm is {area:F2} square centimeters");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
