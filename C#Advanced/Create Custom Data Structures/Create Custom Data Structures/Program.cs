using System;

namespace Create_Custom_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(3);
            list.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Swap(0, 1);
            list.InsertAt(0, 7);
            Console.WriteLine(list.Contains(7));
            Console.WriteLine(list.RemoveAt(1));
            Console.WriteLine(list.RemoveAt(1));
            Console.WriteLine(list.RemoveAt(0));

        }
    }
}
