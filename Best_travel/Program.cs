using System;
using System.Collections.Generic;

namespace Best_travel
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa solution by TobiH

            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = SumOfK.chooseBestSum(163, 3, ts);
            Console.WriteLine($"result: {n}");
            Console.ReadLine();
        }
    }
    public static class SumOfK
    {
        public static int? chooseBestSum(int t, int k, List<int> ls, int r = 0)
        {
            int? d = t;
            for (int a = r; a < ls.Count; a++)
            {
                int? result = k == 1 ? t - ls[a] : chooseBestSum(t - ls[a], k - 1, ls, a + 1);
                if (result < d && result >= 0) d = result;
            }
            if (d == t) return null;
            return (r == 0 ? t - d : d);
        }
    }
}

