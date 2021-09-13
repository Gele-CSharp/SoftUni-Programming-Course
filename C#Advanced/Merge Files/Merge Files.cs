using System;
using System.IO;
using System.Threading.Tasks;

namespace Merge_Files
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader streamInput1 = new StreamReader("Input1.txt"))
            {
                using (StreamReader streamInput2 = new StreamReader("Input2.txt"))
                {
                    using (StreamWriter output = new StreamWriter("Output.txt"))
                    {
                        string input1line = await streamInput1.ReadLineAsync();
                        string input2Line = await streamInput2.ReadLineAsync();

                        while (input1line != null && input2Line != null)
                        {
                            await output.WriteLineAsync(input1line);
                            await output.WriteLineAsync(input2Line);

                            input1line = await streamInput1.ReadLineAsync();
                            input2Line = await streamInput2.ReadLineAsync();
                        }
                    }
                }
            }
        }
    }
}
