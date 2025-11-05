/*
 * LinkedList - Listas Encadeadas
 * 
 */
using System.Collections.Generic;

public class LinkedListExample
{
    public static void Main()
    {
        // Creating and reading a LinkedList from an string array
        string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> sentence = new LinkedList<string>(words);
        int count = 0;

        // Showing separate informations from the Nodes
        Console.WriteLine("> Showing all Nodes inside the LinkedList: \n");
        foreach (string word in sentence)
        {
            count++;
            Console.WriteLine($"Node[{count}] = {word}");
        }

        // Show the information from the Nodes:
        Console.WriteLine("> \nShowing important informations from the LinkedList: \n");
        int numberNodes = sentence.Count;
        LinkedListNode<string> firstNode = sentence.First;
        LinkedListNode<string> lastNode = sentence.Last;
        Console.WriteLine($"Number of Nodes: {numberNodes}");
        Console.WriteLine($"First Node into the LinkedList: {firstNode.Value}");
        Console.WriteLine($"Last Node into the LinkedList: {lastNode.Value}");
        Console.WriteLine($"Previous Node from the last Node into the LinkedList: {lastNode.Previous.Value}");
        Console.WriteLine($"Next Node from the First Node into the LinkedList: {firstNode.Next.Value}");


        // Add a value in the beggining of the LinkedList
        Console.WriteLine("\n> Adding the value \"today\" in the beggining of the LinkedList: \n");
        sentence.AddFirst("today"); // ! is a null-forgiving symbol - allow to say that it's not possible to be null.
        sentence.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n");

        // Add a value in the end of the LinkedList
        Console.WriteLine("\n> Adding the value \"again\" in the beggining of the LinkedList: \n");
        sentence.AddLast("again");
        sentence.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n");

        // Remove the first value from the LinkedList
        Console.WriteLine("\n> Removing the first value from the LinkedList:\n");
        sentence.RemoveFirst();
        sentence.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n");

        // Remove the last value from the LinkedList
        Console.WriteLine("\n> Removing the last value from the LinkedList:\n");
        sentence.RemoveLast();
        sentence.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n");

        // Move the last node into the first
        Console.WriteLine("\n> Move the last node into the first Node:\n");
        var lastValue = sentence.Last;
        sentence.RemoveLast();
        sentence.AddFirst(lastValue);
        sentence.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine("\n");
    
        // Find a word inside the LinkedList
        Console.WriteLine("\n> Find the word inside the LinkedList:\n");
        var findNode = sentence.Find("jumps");
        if (findNode != null)
        {
          Console.WriteLine($"Found the Node \"jumps\" inside the LinkedList: {findNode.Value}");
        }
    }


}
