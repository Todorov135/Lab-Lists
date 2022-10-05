using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    Add(number, input);
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
                else if (tokens[0] == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    Contain(number, input);

                }
                else if (tokens[0] == "PrintEven")
                {
                    PrintEven(input);
                }
                else if (tokens[0] == "PrintOdd")
                {
                    PrintOdd(input);
                }
                else if (tokens[0] == "GetSum")
                {
                    GetSum(input);
                }
                else if (tokens[0] == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);
                    Filter(condition, number, input);
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
        private static void Contain(int number, List<int> input)
        {
            if (input.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        private static void PrintEven(List<int> input)
        {
            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
        private static void PrintOdd(List<int> input)
        {
            foreach (var number in input)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
        private static void GetSum(List<int> input)
        {
            Console.WriteLine(input.Sum()); 
        }
        private static void Filter(string condition, int number, List<int> input)
        {
            if (condition == "<")
            {
                foreach (var item in input)
                {
                    if (item < number)
                    {
                        Console.Write( item + " ");
                    }

                }
                Console.WriteLine();
            }
            else if (condition == "=<")
            {
                foreach (var item in input)
                {
                    if (item <= number)
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">")
            {
                foreach (var item in input)
                {
                    if (item > number)
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                foreach (var item in input)
                {
                    if (item >= number)
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
