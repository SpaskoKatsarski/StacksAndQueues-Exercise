using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = arr[0];
            int elementsToPop = arr[1];
            int searchedElement = arr[2];

            Queue<int> queue = new Queue<int>();

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(list[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(searchedElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
