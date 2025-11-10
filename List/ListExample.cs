/**
 * LIST EXAMPLE
 *
 */

using System.Linq;
using System;
using System.Collections.Generic;

// Start a new List
List<string> exampleList = new List<string>();

// Add data into the List
exampleList.Add("1");
exampleList.Add("2");
exampleList.Add("3");
exampleList.Add("4");
exampleList.Add("5");
exampleList.Add("6");

// Show all the list values
Console.WriteLine("Visualization of the List created: \n");
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Show the number of elements
int listSize = exampleList.Count;
Console.WriteLine($"Number of elements inside the List: {listSize} \n");

// Looking for a specific value
Console.WriteLine("\nLooking for the value 3...");
Console.WriteLine("Verifying if the value exists: ");

if (exampleList.Contains("3"))
{
  Console.WriteLine("The value 3 exists into the List!");
  int location = exampleList.IndexOf("3");
  Console.WriteLine($"The location of the value 3 (starting at index 0) is in {location}");
  Console.WriteLine("\n");
}

// Revert the List
Console.WriteLine("Revert the elements of the List");
exampleList.Reverse();
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Sort the List
Console.WriteLine("Sort the elements of the List");
exampleList.Sort();
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Get only the pair values using LINQ
Console.WriteLine("Getting the pair numbers of a List: \n");
List<string> pairNumbers = new List<string>();
pairNumbers = exampleList
  .Where(n => Convert.ToInt32(n) % 2 == 0)
  .OrderBy(n => n)
  .ToList();

pairNumbers.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Remove an element of the list
Console.WriteLine("Removing the value 6 from the List:\n");
exampleList.Remove("6");
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Remove an element from a specific index
Console.WriteLine("Removing the value 5 from the index 4: \n");
exampleList.RemoveAt(4);
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Add an element into an specific index
Console.WriteLine("Adding back the value 5 into the index 4: \n");
exampleList.Insert(4,"5");
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Add the number 6 and the 7 into the List from an array
Console.WriteLine("Adding back the value 6 and a new value 7 into the end of the list: \n ");
exampleList.AddRange(new string[] { "6", "7" }); // Add multiple values at once
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");

// Clear all List
Console.WriteLine("Clearing all the List! \n");
exampleList.Clear();
exampleList.ToList().ForEach(item => Console.Write($" | {item} "));
Console.WriteLine("\n");
