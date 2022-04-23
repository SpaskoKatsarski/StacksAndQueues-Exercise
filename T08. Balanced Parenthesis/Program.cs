using System;
using System.Collections.Generic;

namespace T08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allParentheses = Console.ReadLine();

            Stack<char> firstHalf = new Stack<char>();

            for (int i = 0; i < allParentheses.Length / 2; i++)
            {
                firstHalf.Push(allParentheses[i]);
            }

            // { [[[ ]]] } - breaks the program

            Queue<char> secondHalf = new Queue<char>();

            for (int i = allParentheses.Length / 2; i < allParentheses.Length; i++)
            {
                if (i == allParentheses.Length / 2 && allParentheses[i] == ' ')
                {
                    continue;
                }

                secondHalf.Enqueue(allParentheses[i]);
            }

            if (firstHalf.Count != secondHalf.Count)
            {
                Console.WriteLine("NO");
                return;
            }

            bool areBalanced = true;
            
            for (int i = 0; i < firstHalf.Count; i++)
            {
                char stackBracket = firstHalf.Pop();
                char queueBracket = secondHalf.Dequeue();

                if (stackBracket == '(')
                {
                    if (queueBracket != ')')
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else if (stackBracket == '[')
                {
                    if (queueBracket != ']')
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else if (stackBracket == '{')
                {
                    if (queueBracket != '}')
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else
                {
                    if (queueBracket != stackBracket)
                    {
                        areBalanced = false;
                        break;
                    }
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
