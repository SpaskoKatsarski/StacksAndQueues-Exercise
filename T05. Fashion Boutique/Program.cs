using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int racksUsed;

            int[] sequenceOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> pileOfClothes = new Stack<int>(sequenceOfClothes);

            if (pileOfClothes.Any())
            {
                racksUsed = 1;
            }
            else
            {
                Console.WriteLine(0);
                return;
            }

            int currentRackTotal = 0;

            while (pileOfClothes.Any())
            {
                int clothingValue = pileOfClothes.Peek();

                if (currentRackTotal + clothingValue >= rackCapacity)
                {
                    currentRackTotal = 0;
                    racksUsed++;
                }
                else
                {
                    currentRackTotal += clothingValue;
                    pileOfClothes.Pop();
                }
            }

            Console.WriteLine(racksUsed);
        }
    }
}
