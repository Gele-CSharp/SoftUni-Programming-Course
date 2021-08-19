using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int data = int.Parse(Console.ReadLine());
                ProcessDataType(data);
            }
            else if (input == "real")
            {
                double data = double.Parse(Console.ReadLine());
                ProcessDataType(data);
            }
            else if (input == "string")
            {
                string data = Console.ReadLine(); 
                ProcessDataType(data);
            }
        }

        public static void ProcessDataType(string data)
        {
            data = "$" + data + "$";
            Console.WriteLine(data);
        }

        public static void ProcessDataType(int data)
        {
            data *= 2;
            Console.WriteLine(data);
        }

        public static void ProcessDataType(double data)
        {
            data *= 1.5;
            Console.WriteLine($"{data:f2}");
        }
    }
}
