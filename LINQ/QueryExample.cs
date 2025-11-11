/*
 *
 * LINQ - Language Integrated Query
 *
 * Documentation: https://learn.microsoft.com/en-us/dotnet/csharp/linq/
 *
 */

using System.Collections.Generic;
using System.Linq;

// Create the list
List<int> values = new List<int>();

// Generate Random number using Random() and LINQ
Random number = new Random();
values = Enumerable.Range(0,10).Select(_ => number.Next(1,101)).ToList();
Console.WriteLine("Creating a List with 10 random numbers!\n");

// Print a List using LINQ
values.ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");

// Sort values using LINQ
IEnumerable<int> sortedList = 
  from value in values
  orderby value ascending
  select value;

sortedList.ToList().ForEach(item => Console.Write($" {item} | "));
Console.WriteLine("\n");
