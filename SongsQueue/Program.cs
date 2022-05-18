using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            while (songsQueue.Count > 0) //while we still have songs in the queue
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();

                if (cmdArgs[0] == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (cmdArgs[0] == "Add")
                {
                    string songToAdd = string.Join(" ", cmdArgs.Skip(1));

                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songToAdd);
                    }
                }
                else if (cmdArgs[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
