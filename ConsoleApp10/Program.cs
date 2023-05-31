using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. Range");
            Console.WriteLine("2. Contains");
            Console.WriteLine("3. If Else Fail");
            Console.WriteLine("4. Numbri püramiid");

            int choice = Convert.ToInt16(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Range();
                    break;

                case 2:
                    Contains();
                    break;

                case 3:
                    Fail();
                    break;

                case 4:
                    Pyramid();
                    break;

                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;

            }
        }
        static void Range()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        static void Contains()
        {
            int[] number = { 1, 2, 3, 5, 6 };

            bool containsThree = number.Contains(1);
            bool containsFour = number.Contains(4);

            Console.WriteLine(containsThree);
            Console.WriteLine(containsFour);
        }
        static void Fail()
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:/Users/Opilane/Desktop/WriteToFile.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        static void Pyramid()
        {
            Console.WriteLine("\nSisesta kolmnurga suurus");

            double length = double.Parse(Console.ReadLine());

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = " ";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if (row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark = "2";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}