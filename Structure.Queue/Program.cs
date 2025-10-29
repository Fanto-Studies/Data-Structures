using System;
using System.Collections;
using System.Collections.Generic;
using GenericMethods;
using System.Diagnostics;


namespace StackExample
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Basic Stack -> LIFO (Last in, First Out)");
            Stack stack = new Stack();
            Console.WriteLine("Add the value 1 into the stack...");
            stack.Push(1);
            Console.WriteLine("Add the value 2 into the stack...");
            stack.Push(2);
            Console.WriteLine("Add the value 3 into the stack...");
            stack.Push(3);
            Console.WriteLine("Add the value 4 into the stack...");
            stack.Push(4);
            Console.WriteLine("Add the value 5 into the stack...");
            stack.Push(5);
            Console.WriteLine("Add the value 6 into the stack...");
            stack.Push(6);

            Console.WriteLine("Basic stack verification!\n");
            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine($"Values Inside: \n");
            Utility.PrintValues(stack);
            Console.WriteLine("");
            Console.WriteLine($"Pop the first one: {stack.Pop()} ");
            Console.WriteLine($"Peek the next value: {stack.Peek()} ");

            Console.WriteLine("\n\nGeneric Stack -> LIFO (Last in, First Out)");
            Stack<string> genericStack = new Stack<string>();
            Console.WriteLine("Add the value Hello into the stack...");
            genericStack.Push("Hello");
            Console.WriteLine("Add the value World into the stack...");
            genericStack.Push("World");
            Console.WriteLine("Add the value ! into the stack...");
            genericStack.Push("!");

            Console.WriteLine("\nGeneric Stack verification!");
            Console.WriteLine($"Stack count: {genericStack.Count} ");
            Console.WriteLine($"Values Inside: \n");
            Utility.PrintValues(genericStack);
            Console.WriteLine();
            Console.WriteLine($"Pop the first one: {genericStack.Pop()} ");
            Console.WriteLine($"Peek the next value: {genericStack.Peek()} ");
            
            Performance perf = new Performance();
            Console.WriteLine("Testing Stack Performances: \n");
            perf.TestBasicStackPerformance();
            perf.TestGenericStackPerformance();
        }

    }
}