using System;
using System.Collections.Generic;

Queue<string> queue = new Queue<string>();

// Adding value into the Queue
Console.WriteLine("Adding values into the Queue: ");
Console.WriteLine("Adding value 1");
queue.Enqueue("1");
Console.WriteLine("Adding value 2");
queue.Enqueue("2");
Console.WriteLine("Adding value 3");
queue.Enqueue("3");
Console.WriteLine("Adding value 4");
queue.Enqueue("4");
Console.WriteLine("Adding value 5");
queue.Enqueue("5");
Console.WriteLine("Adding value 6");
queue.Enqueue("6");

// Showing the values inside the Queue
Console.WriteLine($"Number of elements from the queue: {queue.Count}");
Console.WriteLine("Showing the values inside the Queue in the original order: \n");
queue.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");

// Dequeue a value
Console.WriteLine("Getting the first value to dequeue (FIFO): ");
Console.WriteLine($"Value to dequeue is: {queue.Peek()} ");
string value = queue.Dequeue();
Console.WriteLine($"The value was dequeued!");
Console.WriteLine("The Queue at this moment: \n");
queue.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");

// Copy the queue into another queue
Console.WriteLine("Copying the queue into a new queue using the ToArray()");
Queue<string> queueCopy = new Queue<string>(queue.ToArray());
Console.WriteLine("Showing the values inside the copy of the Queue in the original order: \n");
queue.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");

// Check the number of elements and clear the queue
Console.WriteLine($"Number of elements after dequeue: {queue.Count}");
Console.WriteLine("Clearing the queue using clear()");
queue.Clear();
Console.WriteLine("Queue after the clear: \n");
queue.ToList().ForEach(item => Console.Write($" | {item}"));
Console.WriteLine("\n");


