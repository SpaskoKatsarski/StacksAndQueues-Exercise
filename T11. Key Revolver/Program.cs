using System;
using System.Collections.Generic;
using System.Linq;

namespace T11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            int fee = 0;
            int bulletsInBarrel = gunBarrelSize;

            while (bullets.Any() && locks.Any())
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();

                if (currentLock >= currentBullet)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                bulletsInBarrel--;
                fee += pricePerBullet;

                if (bulletsInBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    bulletsInBarrel = gunBarrelSize;
                }
            }

            if (!locks.Any())
            {
                int moneyEarned = intelligenceValue - fee;

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else if (!bullets.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
