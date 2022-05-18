using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            foreach (char item in input)
            {
                if (item == '(' ||
                    item == '[' ||
                    item == '{')
                {
                    stack.Push(item);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                if (item == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (item == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (item == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        //    string input = Console.ReadLine();

        //    Stack<char> stack = new Stack<char>(input.Substring(0, input.Length / 2));
        //    Queue<char> queue = new Queue<char>(input.Substring(input.Length / 2));

        //    if (queue.Peek() == ' ')
        //    {
        //        queue.Dequeue();
        //    }

        //    bool isBalanced = true;

        //    while (stack.Count > 0 && queue.Count > 0)
        //    {
        //        char currBracket = 'x';

        //        if (stack.Count > 0)
        //        {
        //            currBracket = stack.Pop();
        //        }

        //        if (queue.Count == 0)
        //        {
        //            isBalanced = false;
        //            break;
        //        }

        //        if (currBracket == '(')
        //        {
        //            if (queue.Dequeue() != ')')
        //            {
        //                isBalanced = false;
        //                break;
        //            }
        //        }
        //        else if (currBracket == '[')
        //        {
        //            if (queue.Dequeue() != ']')
        //            {
        //                isBalanced = false;
        //                break;
        //            }
        //        }
        //        else if (currBracket == '{')
        //        {
        //            if (queue.Dequeue() != '}')
        //            {
        //                isBalanced = false;
        //                break;
        //            }
        //        }
        //        else if (currBracket == ' ')
        //        {
        //            if (queue.Dequeue() != ' ')
        //            {
        //                isBalanced = false;
        //                break;
        //            }
        //        }
        //    }

        //    if (isBalanced)
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO");
        //    }
        }
    }
}
