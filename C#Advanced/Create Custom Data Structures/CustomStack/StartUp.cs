using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Console.WriteLine(stack.Peek());


        }
    }
}