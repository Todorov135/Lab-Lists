using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    Add(number , input);
                }
                else if (tokens[0] == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    Remove(number, input);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    RemoveAt(index, input);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    Insert(number, index, input);
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }

        

        private static void Add(int number, List<int> input)
        {
            input.Add(number);
        }
        private static void Remove(int number, List<int> input)
        {
            input.Remove(number);
        }
        private static void RemoveAt(int index, List<int> input)
        {
            input.RemoveAt(index);
        }
        private static void Insert(int number, int index, List<int> input)
        {
            input.Insert(index, number);
        }
    }
}
