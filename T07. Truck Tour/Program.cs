using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrol = new Queue<int>();
            var distance = new Queue<int>();
            int[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }
            int currentFuel;
            var petrolCopy = new Queue<int>();
            var distanceCopy = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                currentFuel = petrol.Peek();
                for (int x = 0; x < n; x++)
                {
                    if (distance.Peek() <= currentFuel)
                    {
                        currentFuel -= distance.Peek();
                        if (x == n - 1)
                        {
                            Console.WriteLine(i);
                            return;
                        }
                    }
                    else
                    {
                        for (int y = x; y < n; y++)
                        {
                            petrol.Enqueue(petrol.Dequeue());
                            distance.Enqueue(distance.Dequeue());
                        }
                        break;
                    }
                    petrol.Enqueue(petrol.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                    currentFuel += petrol.Peek();
                }
                petrol.Enqueue(petrol.Dequeue());
                distance.Enqueue(distance.Dequeue());
            }

            //int circles = int.Parse(Console.ReadLine());

            //Queue<int[]> queue = new Queue<int[]>();

            //for (int i = 0; i < circles; i++)
            //{
            //    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //    queue.Enqueue(arr);
            //}

            //int validStation = 0;

            //for (int i = 0; i < circles; i++)
            //{
            //    bool isComplete = true;
            //    int tankFuel = 0;

            //    foreach (var item in queue)
            //    {
            //        int currLiters = item[0];
            //        int currDistance = item[1];

            //        tankFuel += currLiters;

            //        if (tankFuel - currDistance < 0)
            //        {
            //            validStation++;
            //            isComplete = false;
            //            queue.Dequeue();
            //            queue.Enqueue(item);
            //            break;
            //        }

            //        tankFuel -= currDistance;
            //    }

            //    if (isComplete)
            //    {
            //        Console.WriteLine(validStation);
            //        break;
            //    }
            //}
        }
    }
}
