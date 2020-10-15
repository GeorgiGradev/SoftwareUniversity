using System;
using System.IO;
using System.Linq;
using System.Text;
namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"E:\1. C# PROGRAMMNG\03. C# Advanced\01. C# Advanced TUTORIALS\09. Streams, Files and Directories - Lab\Resources\06. Folder Size\TestFolder");
            double size = 0;
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                size += info.Length;
            }
            Console.WriteLine($"{size / 1024 / 1024:f14}");
        }
    }
}
