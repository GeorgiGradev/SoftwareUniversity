using System;
using System.IO;
using System.Linq;
using System.Text;
namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("data", "input.txt");

            using FileStream stream = new FileStream(path1, FileMode.OpenOrCreate);
            int parts = 4;
            var length = (int)Math.Ceiling(stream.Length / (decimal)parts);

            byte[] buffer = new byte[length];

            for (int i = 0; i < parts; i++)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesRead)
                        .ToArray();
                }
                string path2 = Path.Combine("data", $"Part{i + 1}.txt");
                using var currenrPartStream = new FileStream(path2, FileMode.OpenOrCreate);
                currenrPartStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
