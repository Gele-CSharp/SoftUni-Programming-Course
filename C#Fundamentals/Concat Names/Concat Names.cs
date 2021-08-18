using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(firstname+delimiter+lastname);
        }
    }
}
