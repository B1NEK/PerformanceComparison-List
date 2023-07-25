using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "/Users/petrbinek/Desktop/Povtoreniya.txt";
        string text = System.IO.File.ReadAllText(filePath);
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> list = new List<string>();
        LinkedList<string> linkedList = new LinkedList<string>();

        Stopwatch listInsertionStopwatch = new Stopwatch();
        Stopwatch linkedListInsertionStopwatch = new Stopwatch();

        // Вставка слов в List<T>
        listInsertionStopwatch.Start();
        foreach (string word in words)
        {
            list.Add(word);
        }
        listInsertionStopwatch.Stop();

        // Вставка слов в LinkedList<T>
        linkedListInsertionStopwatch.Start();
        foreach (string word in words)
        {
            linkedList.AddLast(word);
        }
        linkedListInsertionStopwatch.Stop();

        // Вывод результатов измерений времени вставки в консоль
        Console.WriteLine("Вставка в List<T>: " + listInsertionStopwatch.Elapsed);
        Console.WriteLine("Вставка в LinkedList<T>: " + linkedListInsertionStopwatch.Elapsed);
    }
}

