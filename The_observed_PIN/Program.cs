using System;
using System.Collections.Generic;

namespace The_observed_PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/5263c6999e0f40dee200059d solution by TobiH

            Kata.GetPINs("8").ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            Kata.GetPINs("11").ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            Kata.GetPINs("369").ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
    public class Kata
    {
        public static List<List<int>> nb = new List<List<int>>() { new List<int>{ 0, 8 }, new List<int>{1, 2, 4}, new List<int> { 1, 2, 3, 5 }, new List<int> { 2, 3, 6 }, new List<int> { 1, 4, 5, 7 }, new List<int> { 2, 4, 5, 6, 8 }, new List<int> { 3, 5,6,  9 }, new List<int> { 4, 7, 8 }, new List<int> { 5, 7, 8, 9, 0 }, new List<int> { 6, 8, 9 } };
        public static List<string> GetPINs(string observed)
        {
            List<string> result = new List<string>();

            int d = observed[0] - '0';

            if (observed.Length == 1) nb[d].ForEach(x => result.Add($"{x}"));
            else GetPINs(observed.Substring(1)).ForEach(x => nb[d].ForEach(x2 => result.Add($"{x2}{x}")));

            return result;
        }
    }
}
