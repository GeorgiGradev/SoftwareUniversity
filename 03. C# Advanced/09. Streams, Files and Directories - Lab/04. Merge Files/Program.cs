using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("data", "input1.txt");
            string path2 = Path.Combine("data", "input2.txt");
            string path3 = Path.Combine("data", "output.txt");

            string[] path1nums = File.ReadAllLines(path1);
            string[] path2nums = File.ReadAllLines(path2);

            List<int> nums = new List<int>();

            for (int i = 0; i < path1nums.Length; i++)
            {
                nums.Add(int.Parse(path1nums[i]));
            }
            for (int i = 0; i < path2nums.Length; i++)
            {
                nums.Add(int.Parse(path2nums[i]));
            }
            nums = nums.OrderBy(x => x).ToList();
            List<string> numsAsString = new List<string>();

            foreach (var item in nums)
            {
                string number = item.ToString();
                numsAsString.Add(number);
            }

            File.WriteAllLines(path3, numsAsString);

        }
    }
}
