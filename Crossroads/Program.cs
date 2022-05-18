using System;
using System.Collections.Generic;

namespace Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string command; //a car, green, END

            int passedCars = 0;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int currGreenLight = greenLightDuration;

                    while (currGreenLight > 0 && queue.Count > 0)
                    {
                        int index;

                        string currentCar = queue.Dequeue();

                        if (currGreenLight > 0)
                        {
                            if (currentCar.Length > currGreenLight)
                            {
                                index = currGreenLight;
                                currGreenLight -= currentCar.Length;

                                if (index + freeWindowDuration < currentCar.Length)
                                {
                                    //car accident
                                    index += freeWindowDuration;

                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[index]}.");

                                    return;
                                }

                                passedCars++;
                            }
                            else
                            {
                                currGreenLight -= currentCar.Length;
                                passedCars++;
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
