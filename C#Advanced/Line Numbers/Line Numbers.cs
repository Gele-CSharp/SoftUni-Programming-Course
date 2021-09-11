using System;
using System.IO;
using System.Threading.Tasks;

namespace Line_Numbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("Input.txt"))
            {
                string line = await str.ReadLineAsync();
                int counter = 1;

                using (StreamWriter output = new StreamWriter("Output.txt")) 
                {
                    while (line != null)
                    {
                        await output.WriteLineAsync($"{counter}. {line}");
                        counter++;
                        line = await str.ReadLineAsync();
                    }
                }
            }
        }
    }
}
