using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine().Split().ToList();
            List<string> secondList = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();

            int biggestList = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < biggestList; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);

                }
                if(secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }
            }

            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
