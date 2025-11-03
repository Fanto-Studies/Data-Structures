using System;
using System.Collections;
using System.Collections.Generic;

/*
 * STACK - PILHA
 *
 * LIFO -> Last-In, First-Out
 *
 */

// ---------------------------------------
// Start the Generic stack of type String
// ---------------------------------------
Stack<string> stack = new Stack<string>();

// Add the values inside the stack
Console.WriteLine("Adding data inside the Stack:\n");
Console.WriteLine("Adding value 1");
stack.Push("1");
Console.WriteLine("Adding value 2");
stack.Push("2");
Console.WriteLine("Adding value 3");
stack.Push("3");
Console.WriteLine("Adding value 4");
stack.Push("4");
Console.WriteLine("Adding value 5");
stack.Push("5");
Console.WriteLine("Adding value 6");
stack.Push("6");

// Show information inside the stack
Console.WriteLine("Showing the data and order into the Stack:\n");
stack.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");

// Show the number of values
int numberValues = stack.Count;
Console.WriteLine($"Number of values inside the stack: {numberValues}\n");

// Get the last value added
Console.WriteLine($"Pop the last value added (LIFO): {stack.Peek()}\n");
stack.Pop();
Console.WriteLine("Stack after pop(): \n");
stack.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");

// Verify if a value is in the stack
Console.WriteLine("Verifying if there's value 1 inside the Stack.");
if (stack.Contains("1")) Console.WriteLine("The Stack have the value 1\n");

// Verify the next value that can be removed from the Stack
string nextValue = stack.Peek();
Console.WriteLine($"Next value to Pop into the Stack: {nextValue}\n");





