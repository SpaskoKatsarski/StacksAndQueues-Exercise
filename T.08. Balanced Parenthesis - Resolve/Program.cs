using System;
using System.Collections.Generic;
using System.Linq;

namespace T._08._Balanced_Parenthesis___Resolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> openingBrackets = new Stack<char>();

            bool areBalanced = true;

            foreach (var item in input)
            {
                if (item == '('||
                    item == '[' ||
                    item == '{')
                {
                    openingBrackets.Push(item);
                    continue;
                }

                if (openingBrackets.Count == 0)
                {
                    areBalanced = false;
                    break;
                }

                if (item == ')' && openingBrackets.Peek() == '(')
                {
                    openingBrackets.Pop();
                }
                else if (item == ']' && openingBrackets.Peek() == '[')
                {
                    openingBrackets.Pop();
                }
                else if (item == '}' && openingBrackets.Peek() == '{')
                {
                    openingBrackets.Pop();
                }
                else
                {
                    areBalanced = false;
                    break;
                }
            }

            if (areBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
