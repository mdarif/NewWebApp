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

// Creating a list of names
var names = new List<string> { "Alice", "Bob", "Charlie" };

// Adding more names to the list
names.Add("David");
names.Add("Eve");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}

// Accessing the last element using the index
Console.WriteLine(names[^1]);

// Creating an array of names
var persons = new string[] { "Abc", "Def", "Ghi" };

// add new person names in persons
persons = [..persons, "Jkl", "Mno"];

// Iterating over the array
foreach (var person in persons)
{
    Console.WriteLine($"Hello {person.ToUpper()}!");
}

// Sorting and Searching Lists from https://www.youtube.com/watch?v=2sp4gWCq3o4

// Creating a list of names
// var namesList = new List<string> { "Eve","Alice", "Bob", "Charlie", "David" };
var numbers = new List<int> { 45, 56, 12, 34, 23, 100, 78 };

numbers.Sort();
numbers.Remove(100);
// numbers.IndexOf(45);
Console.WriteLine($"I found 45 at index {numbers.IndexOf(45)}");

foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}


// Language Integrated Query (LINQ) and IEnumerable [Pt 15] | C# for Beginners 
// from https://www.youtube.com/watch?v=4ro5UCqU0P4

// Specify the data source.
List<int> scores = [97, 92, 81, 60];

// IMPERATIVE PROGRAMMING
/* for(int i = 0; i < scores.Count; i++)
{
    if (scores[i] > 80)
    {
        Console.WriteLine($"Found a score greater than 80: {scores[i]}");
    }
} */

// DECLARATIVE PROGRAMMING
// Define the query expression.
IEnumerable<string> scoreQuery = //query variable
    from score in scores // required
    where score > 80 // optional
    orderby score ascending // optional
    select $"The score is {score}"; // must end with select or group

int scoreCount = scoreQuery.Count();
Console.WriteLine($"Found {scoreCount} scores greater than 80");

// Execute the query.
foreach (string score in scoreQuery)
{
    Console.WriteLine(score);
}

// LINQ Query Expressions From, Where, Orderby, and Select [Pt 16] | C# for Beginners
// from https://www.youtube.com/watch?v=Wy1pvmcEqKw (similar to above)

// LINQ Method Syntax vs Query [Pt 17] | C# for Beginners
// from https://www.youtube.com/watch?v=jAPcP-QbCGA

// Specify the data source.
List<int> scores2 = [97, 92, 81, 60];

var scoreQuery2 = scores2.Where(score => score > 80).
            OrderByDescending(score => score);

// Convert the LINQ query result to a List<int> using collection expression syntax
// The spread operator (..) creates a new list containing all elements from scoreQuery2
// Alternative method: scoreQuery2.ToList() achieves the same result
List<int> myScores = [.. scoreQuery2];

foreach (var score in myScores)
{
    Console.WriteLine(score);
}
