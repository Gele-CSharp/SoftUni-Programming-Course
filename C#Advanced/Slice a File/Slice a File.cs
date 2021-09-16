using System;
using System.IO;
using System.Threading.Tasks;

namespace Slice_a_File
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int parts = 4;
            byte[] buffer = new byte[4096];
            int totalBytes = 0;

            using (FileStream fileToSlice = new FileStream("FileToSlice.txt", FileMode.Open, FileAccess.Read))
            {
                int sizeOfPart = (int)(Math.Ceiling((double)fileToSlice.Length / parts));

                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;

                    using (FileStream output = new FileStream($"Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (readBytes < sizeOfPart && totalBytes < fileToSlice.Length)
                        {
                            int bytesToRead = Math.Min(buffer.Length, sizeOfPart - readBytes);
                            int bytes = await fileToSlice.ReadAsync(buffer, 0, bytesToRead);
                            await output.WriteAsync(buffer, 0, bytes);
                            readBytes += bytes;
                            totalBytes += bytes;
                        }
                    }
                }
            }
        }
    }
}
