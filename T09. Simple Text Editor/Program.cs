using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<char> stack = new Stack<char>();
            var builder = new StringBuilder();

            Stack<string> queueForFirstCommand = new Stack<string>();
            Stack<List<char>> queueForSecondCommand = new Stack<List<char>>();

            Stack<bool> commandStack = new Stack<bool>(); // first - add false, second - add true

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');

                string cmdName = cmdArgs[0];
                
                if (cmdName == "1")
                {
                    char[] arr = cmdArgs[1].ToCharArray();

                    // 1 abc
                    for (int j = 0; j < cmdArgs[1].Length; j++)
                    {
                        stack.Push(arr[j]);
                    }

                    //1
                    queueForFirstCommand.Push(cmdArgs[1]);
                    commandStack.Push(true);
                }
                else if (cmdName == "2")
                {
                    List<char> list = new List<char>();

                    int countToErase = int.Parse(cmdArgs[1]);

                    for (int j = 0; j < countToErase; j++)
                    {
                        list.Add(stack.Pop());
                    }

                    list.Reverse();

                    queueForSecondCommand.Push(list);
                    commandStack.Push(false);
                }
                else if (cmdName == "3")
                {
                    // abc
                    // int top = stack.ElementAt(0); // Returns c  

                    Console.WriteLine(stack.ElementAt(0 + int.Parse(cmdArgs[1]) - 1));
                    //Console.WriteLine(stack.ElementAt(int.Parse(cmdArgs[1]) - 1 - int.Parse(cmdArgs[1]) - 1)); // returns only the topmost index :(
                }
                else if (cmdName == "4")
                {
                    if (!commandStack.Pop())
                    {
                        List<char> currList = queueForSecondCommand.Pop();

                        for (int j = 0; j < currList.Count; j++)
                        {
                            stack.Push(currList[j]);
                        }
                    }
                    else
                    {
                        string textToRemove = queueForFirstCommand.Pop();

                        for (int j = 0; j < textToRemove.Length; j++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            //while (stack.Any())
            //{
            //    Console.Write(stack.Pop() + " ");
            //}
        } 
    }
}
