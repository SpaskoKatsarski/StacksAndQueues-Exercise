using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(queue.Max());

            while (true)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= queue.Dequeue();

                    if (queue.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
