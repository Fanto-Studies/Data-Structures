/**
 * HASHSET 
 *
 * Store only unique values, without specific order.
 * It's good to look for only unique values, they do not repeat.
 */

using System.Collections.Generic;

// Start a HashSet
HashSet<string> names = new HashSet<string>();

// Add values inside the HashSet
Console.WriteLine("Add values inside the HashSet!\n");
names.Add("Gabriel");
names.Add("Nick");
names.Add("Gabriel"); // This one can't show inside the HashSet

// List all values inside the HashSet
names.ToList().ForEach(item => Console.Write($" {item},"));
Console.WriteLine("\n");

// validate the number of elements
int elements = names.Count;
Console.WriteLine($"Number of elements inside the HashSet: {elements}");

// Check if the value contains inside the HashSet
Console.WriteLine("Validating if the value Gabriel exists inside the HashSet: \n");
if (names.Contains("Gabriel"))
{
  Console.WriteLine("The HashSet contains the value Gabriel");
  Console.WriteLine($"The type of the element is : {names.GetType()}\n");
}

// Remove an Element
Console.WriteLine("Remove the element Nick from the HashSet");
names.Remove("Nick");
Console.WriteLine("HashSet after removed the value: \n");
names.ToList().ForEach(item => Console.Write($" {item},"));
Console.WriteLine("\n");




