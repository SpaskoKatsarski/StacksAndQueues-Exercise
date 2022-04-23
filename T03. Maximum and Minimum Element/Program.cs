using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool firstCommand = false;
            bool secondCommand = false;
            bool thirdCommand = false;
            bool fourthCommand = false;

            while (true)
            {
                if (commandArgs[0] == 1)
                {
                    stack.Push(commandArgs[1]);
                    firstCommand = true;
                }
                else if (commandArgs[0] == 2 && stack.Any())
                {
                    stack.Pop();
                }
                else if (commandArgs[0] == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (commandArgs[0] == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                
                if (commandArgs[0] == 2)
                {
                    secondCommand = true;
                }
                else if (commandArgs[0] == 3)
                {
                    thirdCommand = true;
                }
                else if (commandArgs[0] == 4)
                {
                    fourthCommand = true;
                }

                if (firstCommand && secondCommand && thirdCommand && fourthCommand)
                {
                    break;
                }

                commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
