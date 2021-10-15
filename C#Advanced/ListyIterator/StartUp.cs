using System;
using System.Linq;

namespace ListyIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] create = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] elements = create.Skip(1).ToArray();
            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            string command; 

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext()); 
                }
                else if (command == "Print")
                {
                    listyIterator.Print();
                }
                else if (command == "PrintAll")
                {
                    listyIterator.PrintAll();
                }
            }
        }
    }
}
