// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 18th, 2019
// PURPOSE    : Translate from English to Pig Latin
// ===============================

using System;

namespace Mock_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Number 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Number 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(IsTheSame(5, 6));
            Console.WriteLine(IsTheSame(6, 6));
            Console.WriteLine(Subtract(6, 6));
            Console.WriteLine(Subtract(5, 6));
            Console.WriteLine(Subtract(6, 5));
            Console.WriteLine(FindBuildingType(1));
            Console.WriteLine(FindBuildingType(5));
            Console.WriteLine(FindBuildingType(20));
            Console.WriteLine(FindBuildingType(60));
        }

        public static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static string FindBuildingType(int number)
        {
            string height = "";
            if (number >= 50)
            {
                return "This is a SUPER skyscraper!";
            }
            else if (number <= 49 && number >= 11)
            {
                return "This is a skyscraper!";
            }
            else if (number <= 10 && number >= 4)
            {
                return "This is an office building!";
            }
            else if (number <= 3)
            {
                return "This is a house!";
            }
            return height;
        }
    }
}
