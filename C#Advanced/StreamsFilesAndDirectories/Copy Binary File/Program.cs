using System;
using System.IO;
using System.Threading.Tasks;

namespace Copy_Binary_File
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using FileStream fileToCopy = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read);
            using FileStream writeCopiedFile = new FileStream("copyOfFile.png", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = new byte[4096];

            while (true)
            {
                int bytes = await fileToCopy.ReadAsync(buffer, 0, buffer.Length);

                if (bytes == 0)
                {
                    break;
                }
                
                await writeCopiedFile.WriteAsync(buffer, 0, bytes);
            }
        }
    }
}
