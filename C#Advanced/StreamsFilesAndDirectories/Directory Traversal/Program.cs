using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../", ".");
            var filesList = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = fileInfo.Name;
                string extension = fileInfo.Extension;
                double fileSize = fileInfo.Length / 1024.0;

                if (filesList.ContainsKey(extension) == false)
                {
                    filesList.Add(extension, new Dictionary<string, double>());
                }

                filesList[extension].Add(fileName, fileSize);
            }

            List<string> result = new List<string>();

            foreach (var file in filesList.OrderByDescending(f=> f.Value.Count).ThenBy(f=> f.Key))
            {
                result.Add(file.Key);

                foreach (var item in file.Value)
                {
                    result.Add($"--{item.Key} - {item.Value:f3}kb");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            File.WriteAllLines(path, result);
        }
    }
}
