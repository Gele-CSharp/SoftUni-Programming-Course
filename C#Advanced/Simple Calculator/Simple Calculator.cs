using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stackedInput = new Stack<string>(input);
            
            while(stackedInput.Count > 1)
            {
                int firstNumber = int.Parse(stackedInput.Pop());
                string mathOperator = stackedInput.Pop();
                int secondNumber = int.Parse(stackedInput.Pop());

                if (mathOperator == "+")
                {
                    stackedInput.Push((firstNumber + secondNumber).ToString());
                }
                else if (mathOperator == "-")
                {
                    stackedInput.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stackedInput.Pop());
        }
    }
}
