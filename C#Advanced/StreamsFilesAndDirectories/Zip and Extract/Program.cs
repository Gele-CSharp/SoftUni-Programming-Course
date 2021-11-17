using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = "../../../Source Directory";
            string targetDirectory = "../../../Result.zip";
            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            string resultDirectory = "../../../Result Folder";
            ZipFile.ExtractToDirectory(targetDirectory, resultDirectory);
        }
    }
}
