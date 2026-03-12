using System;
using System.Globalization;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test 1");
        var queue = new SimpleQueue();
        queue.Enqueue(100);
        var value = queue.Dequeue();
        Console.WriteLine(value);

    }
}