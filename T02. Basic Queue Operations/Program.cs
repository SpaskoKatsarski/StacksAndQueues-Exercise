using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operationElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPush = operationElements[0];
            int elementsToPop = operationElements[1];
            int searchedElement = operationElements[2];

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
