using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            box.Add("A");
            box.Add("B");
            box.Add("C");
            Console.WriteLine(box.Count);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);
        }
    }
}
