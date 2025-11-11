/*
 * ARRAY EXAMPLES
 * Documentation: 
 */

// Start Array after C# 12
int[] values = [1,2,3,4,5,6,7,8,9,10];

// Search for Pair values using LINQ
Console.WriteLine("Getting only the Pair numbers using LINQ\n");

IEnumerable<int> pairValues = 
  from value in values
  where value % 2 == 0
  select value;

pairValues.ToList().ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");

// Search for Even values using LINQ
Console.WriteLine("Getting only the Even numbers using LINQ\n");

IEnumerable<int> evenValues = 
  from value in values
  where value % 2 != 0
  select value;

evenValues.ToList().ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");

// Add more values inside the Array after C# 12 and need .NET 8 or above
// This is called collection expressions (..values is a spread expression)
values = [..values,11,12,13];

Console.WriteLine("Adding new values inside the Array using the collection expressions: \n");
values.ToList().ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");

// Informations from the Array
Console.WriteLine($"The Array have the Length {values.Length}");

// Reverse the Array
Array.Reverse(values);
Console.WriteLine($"Reverse the Array: \n");
values.ToList().ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");
Array.Reverse(values);

// Get specific value
Console.WriteLine($"traditional way: Get the value from the index 3: {values[3]}");
Console.WriteLine($"new way: Get the value from the index 3: {values.GetValue(3)}");





