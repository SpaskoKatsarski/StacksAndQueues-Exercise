using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int circles = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < circles; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(arr);
            }
            
            int validStation = 0;

            while (true)
            {
                bool isComplete = true;
                int tankFuel = 0;

                foreach (var item in queue)
                {
                    int currLiters = item[0];
                    int currDistance = item[1];

                    tankFuel += currLiters;

                    if (tankFuel - currDistance < 0)
                    {
                        validStation++;
                        isComplete = false;
                        queue.Dequeue();
                        queue.Enqueue(item);
                        break;
                    }

                    tankFuel -= currDistance;
                }

                if (isComplete)
                {
                    Console.WriteLine(validStation);
                    break;
                }
            }
        }
    }
}
