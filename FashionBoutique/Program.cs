using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());

            int countOfRacks = 1;
            int fulliness = 0;

            while (clothes.Count > 0)
            {
                int currClothing = clothes.Peek();

                if (fulliness + currClothing > rackCapacity)
                {
                    countOfRacks++;
                    fulliness = currClothing;
                }
                else
                {
                    fulliness += currClothing;
                }

                clothes.Pop();
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
