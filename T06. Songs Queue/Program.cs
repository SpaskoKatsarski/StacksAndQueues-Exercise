using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfSongs = Console.ReadLine().Split(", ");

            Queue<string> songsQueue = new Queue<string>(sequenceOfSongs);

            while (songsQueue.Any())
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string action = cmdArgs[0];

                if (action == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (action == "Add")
                {
                    string currentSong = string.Empty;

                    if (cmdArgs.Length > 2)
                    {
                        cmdArgs[0] = string.Empty;
                        currentSong = string.Join(' ', cmdArgs);

                        //" Watch me"
                        //length = 9
                        currentSong = currentSong.Substring(1, currentSong.Length - 1);
                    }
                    else
                    {
                        currentSong = cmdArgs[1];
                    }

                    if (songsQueue.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(currentSong);
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
