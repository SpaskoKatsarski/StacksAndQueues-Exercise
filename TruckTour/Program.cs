using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Pump
    {
        public Pump(int number, int petrolAmount, int distance)
        {
            this.Number = number;
            this.PetrolAmount = petrolAmount;
            this.Distance = distance;
        }

        public int Number { get; set; }

        public int PetrolAmount { get; set; }

        public int Distance { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Pump> pumpsQueue = new Queue<Pump>();

            int countOfPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPumps; i++)
            {
                int[] info = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pumpsQueue.Enqueue(new Pump(i, info[0], info[1]));
            }

            for (int station = 0; station < countOfPumps; station++)
            {
                bool isComplete = true;

                int tankLiters = 0;

                foreach (var pump in pumpsQueue)
                {
                    Pump currPump = pumpsQueue.Peek();

                    int tankFuel = currPump.PetrolAmount;
                    int distanceToNextPump = currPump.Distance;

                    tankLiters += tankFuel;

                    //1 5
                    //10 3
                    //3 4

                    if (tankFuel - distanceToNextPump > 0)
                    {
                        //We can move to the next pump.
                        tankFuel -= distanceToNextPump;
                    }
                    else
                    {
                        isComplete = false;

                        pumpsQueue.Dequeue();
                        pumpsQueue.Enqueue(currPump);
                        break;
                    }
                }

                if (isComplete)
                {
                    Console.WriteLine(station);
                    return;
                }
            }
        }
    }
}
