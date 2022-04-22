using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasEnoughFood = true;

            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orderArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(orderArr);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < orderArr.Length; i++)
            {
                var currentOrder = orders.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    hasEnoughFood = false;
                    break;
                }
            }

            if (hasEnoughFood)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
        }
    }
}
