using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] cmdArgs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (cmdArgs[0] == 1)
                {
                    stack.Push(cmdArgs[1]);
                }
                else if (cmdArgs[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (cmdArgs[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (cmdArgs[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
