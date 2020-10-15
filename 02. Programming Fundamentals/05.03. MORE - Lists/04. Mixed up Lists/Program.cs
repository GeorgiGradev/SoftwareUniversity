using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program // 50 % в JUDGE
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> remaingList = new List<int>();

            if (list1.Count > list2.Count)
            {
                remaingList.Add(list1[list1.Count - 1]);
                remaingList.Add(list1[list1.Count - 2]);
                list1.RemoveAt(list1.Count - 1);
                list1.RemoveAt(list1.Count - 1);
            }
            else
            {
                remaingList.Add(list2[0]);
                remaingList.Add(list2[1]);
                list2.RemoveAt(0);
                list2.RemoveAt(0);
            }

            list2.Reverse();
            List<int> output = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                output.Add(list1[i]);
                output.Add(list2[i]);
            }

            remaingList.Sort();
            output.Sort();

            output.RemoveAll(x => x <= remaingList[0]);
            output.RemoveAll(x => x >= remaingList[1]);
 
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
