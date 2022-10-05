using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> sortedElements = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string inputFood = Console.ReadLine();
                sortedElements.Add(inputFood);
            }
            sortedElements.Sort();
            for (int i = 0; i < sortedElements.Count; i++)
            {
                Console.WriteLine($"{i+1}.{sortedElements[i]}");

            }
        }
    }
}
