using System;
using System.Collections.Generic;

namespace Next_bigger_number_with_the_same_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/55983863da40caa2c900004e solution by TobiH

            Console.WriteLine($"{Kata.NextBiggerNumber(12)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(513)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(2017)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(567890)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(414)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(1234567890)}");
            Console.WriteLine($"{Kata.NextBiggerNumber(9876543210)}");

            Console.ReadLine();
        }
    }
    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            List<long> ls = new List<long>();

            for (long i = n; i > 0;)
            {
                ls.Add(i % 10);
                i /= 10;
                long result = Sum(ls, i * (long)Math.Pow(10, ls.Count), n);
                if (result != long.MaxValue) return result;
            }
            return -1;
        }
        public static long Sum(List<long> ls, long n, long start, int k = 0, long sum = 0)
        {
            long best = long.MaxValue;

            for (int a = k; a < ls.Count; a++)
            {
                if (k == ls.Count - 1) //TODO: optimize last step
                {
                    long result = n + sum * 10 + ls[a];
                    if (result > start) best = result;
                }
                else
                {
                    (ls[a], ls[k]) = (ls[k], ls[a]);
                    long result = Sum(ls, n, start, k + 1, sum * 10 + ls[k]);
                    (ls[a], ls[k]) = (ls[k], ls[a]);
                    if (result < best) best = result;
                }
            }
            return best;
        }
    }
}