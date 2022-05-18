using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> history = new Stack<string>();

            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();

                if (cmdArgs[0] == "1")
                {
                    history.Push(sb.ToString());

                    string strToAppend = cmdArgs[1];
                    sb.Append(strToAppend);
                }
                else if (cmdArgs[0] == "2")
                {
                    history.Push(sb.ToString());

                    int countToErase = int.Parse(cmdArgs[1]);

                    sb.Remove(sb.Length - countToErase, countToErase);
                }
                else if (cmdArgs[0] == "3")
                {
                    int index = int.Parse(cmdArgs[1]);

                    Console.WriteLine(sb[index - 1]);
                }
                else if (cmdArgs[0] == "4")
                {
                    sb = new StringBuilder(history.Pop());
                }
            }
        }
    }
}
