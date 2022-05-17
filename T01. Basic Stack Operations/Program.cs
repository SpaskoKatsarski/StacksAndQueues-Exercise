using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operationElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPush = operationElements[0];
            int elementsToPop = operationElements[1];
            int searchedElement = operationElements[2];

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

            //Stack<int> stackss = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        }
    }
}
