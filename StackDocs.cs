using System;
using System.Collections;
using System.Collections.Generic;

/*
 * STACK - PILHA
 *
 * LIFO -> Last-In, First-Out
 *
 */

// Start the Generic stack 
Stack<string> stack = new Stack<string>();

// Add the values inside the stack
Console.WriteLine("Add data inside the Stack:\n");
stack.Push("1");
stack.Push("2");
stack.Push("3");
stack.Push("4");
stack.Push("5");
stack.Push("6");

// Show information inside the stack
Console.WriteLine("Show the data and order into the Stack:\n");
stack.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("");

// Show the number of values
int numberValues = stack.Count;
Console.WriteLine($"Number of values inside the stack: {numberValues}");

// Get the last value added
Console.WriteLine($"Pop the last value added (LIFO): {stack.Peek()}");
stack.Pop();
Console.WriteLine("Stack after pop(): ");
stack.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("");

// Verify if a value is in the stack
if (stack.Contains("1")) Console.WriteLine("The Stack have the value 1");

// Verify the next value that can be removed from the Stack
string nextValue = stack.Peek();
Console.WriteLine($"Next value to Pop into the Stack: {nextValue}");





