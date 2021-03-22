using System;
using System.Collections.Generic;

namespace Catching_Car_Mileage_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/52c4dd683bfd3b434c000292 solution by TobiH

            Console.WriteLine($"3: {Kata.IsInteresting(3, new List<int>() { 1337, 256 })}");
            Console.WriteLine($"1336: {Kata.IsInteresting(1336, new List<int>() { 1337, 256 })}");
            Console.WriteLine($"1337: {Kata.IsInteresting(1337, new List<int>() { 1337, 256 })}");
            Console.WriteLine($"11208: {Kata.IsInteresting(11208, new List<int>() { 1337, 256 })}");
            Console.WriteLine($"11209: {Kata.IsInteresting(11209, new List<int>() { 1337, 256 })}");
            Console.WriteLine($"11211: {Kata.IsInteresting(11211, new List<int>() { 1337, 256 })}");

            Console.ReadLine();
        }
    }

    public static class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number == 98 || number == 99) return 1;
            if (number < 100) return 0;
            for (int i = 0; i <= 2; i++)
            {
                if (
                AllZero(number + i) ||
                SameNumber(number + i) ||
                Incrementing(number + i) ||
                Decrementing(number + i) ||
                Palindrome(number + i) ||
                awesomePhrases.Contains(number + i))
                    return i == 0 ? 2 : 1;
            }
            return 0;
        }
        private static bool Palindrome(int number)
        {
            string strnum = number.ToString();
            for (int i = 0; i < strnum.Length / 2; i++)
            {
                if (strnum[i] != strnum[strnum.Length - 1 - i]) return false;
            }
            return true;
        }
        private static bool Decrementing(int number)
        {
            int step = number % 10;
            number = number / 10;

            while (number % 10 == step + 1 && number >= 10)
            {
                step = number % 10;
                number = number / 10;
            }
            return number % 10 == step + 1 ? true : false;
        }
        private static bool Incrementing(int number)
        {
            int step = number % 10;
            if (step == 0) step = 10;
            number = number / 10;

            while (number % 10 == step - 1 && number >= 10)
            {
                step = number % 10;
                number = number / 10;
            }
            return number == step - 1 ? true : false;
        }
        private static bool SameNumber(int number)
        {
            int start = number % 10;

            while (number % 10 == start && number >= 10)
            {
                number = number / 10;
            }
            return number == start ? true : false;
        }
        private static bool AllZero(int number)
        {
            while (number % 10 == 0)
            {
                number = number / 10;
            }
            return number < 10 ? true : false;
        }
    }
}
