using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();


            GaussTrick(input);
        }

        static void GaussTrick(List<int> input) 
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                input[i] = input[i] + input[input.Count - 1 - i];
                newList.Add(input[i]);
            }
            if (input.Count % 2 != 0)
            {
                newList.Add(input[input.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
