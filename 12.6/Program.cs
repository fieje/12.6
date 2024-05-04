using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Queue<string> queue = ReadWordsFromFile("input.txt");

        Console.WriteLine("Queue elements:");
        PrintQueue(queue);

        int count = CountElements(queue);
        Console.WriteLine($"Number of elements in the queue: {count}");

        Console.Write("Enter the length of the word to search: ");
        int length = int.Parse(Console.ReadLine());
        PrintWordsWithLength(queue, length);

        Console.WriteLine("Press any key to clear the queue...");
        Console.ReadKey();
        queue.Clear();
        Console.WriteLine("Queue successfully cleared.");
    }

    public static Queue<string> ReadWordsFromFile(string fileName)
    {
        Queue<string> queue = new Queue<string>();
        string[] words = File.ReadAllLines(fileName);
        foreach (string word in words)
        {
            queue.Enqueue(word);
        }
        return queue;
    }

    public static void PrintQueue(Queue<string> queue)
    {
        foreach (string word in queue)
        {
            Console.WriteLine(word);
        }
    }

    public static int CountElements(Queue<string> queue)
    {
        return queue.Count;
    }

    public static void PrintWordsWithLength(Queue<string> queue, int length)
    {
        Console.WriteLine($"Words with length {length}:");
        foreach (string word in queue)
        {
            if (word.Length == length)
            {
                Console.WriteLine(word);
            }
        }
    }
}
