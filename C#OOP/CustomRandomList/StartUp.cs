using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList()
            {
                "Pesho",
                "Gosho",
                "Ivan",
                "Petkan",
                "Dragan"
            };

            Console.WriteLine(randomList.RandomString());
        }
    }
}
