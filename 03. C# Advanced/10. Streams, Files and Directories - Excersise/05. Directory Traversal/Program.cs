using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var files = Directory.GetFiles(input);
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();
            foreach (var filePath in files)
            {
                string fileName = filePath
                    .Split("\\")
                    .Last();
                string extension = fileName
                    .Split(".")
                    .Last();
                FileInfo fileInfo = new FileInfo(fileName);
                double fileSizeInKb = fileInfo.Length / 1024.0;

                if (!dict.ContainsKey(extension))
                {
                    dict.Add(extension, new Dictionary<string, double>());
                }
                dict[extension].Add(fileName, fileSizeInKb);
            }
            StringBuilder sb = new StringBuilder();

            foreach (var (key, value) in dict.OrderByDescending(x => x.Value.Values.Count()).ThenBy(x => x.Key))
            {
                sb.AppendLine($".{key}");
                foreach (var item in value.OrderBy(x => x.Value))
                {
                    sb.AppendLine($"--{item.Key} - {Math.Round(item.Value, 3)}kb");
                }
            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "result.txt");
            File.WriteAllText(path, sb.ToString());
        }
    }
}


