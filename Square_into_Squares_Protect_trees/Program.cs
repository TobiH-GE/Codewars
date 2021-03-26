using System;
using System.Collections.Generic;

namespace Square_into_Squares_Protect_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/54eb33e5bc1a25440d000891 solution by TobiH

            Decompose d = new Decompose();
            Console.WriteLine(d.decompose(11));
            Console.ReadLine();
        }

        public class Decompose
        {
            public string decompose(long n)
            {
                string result = "";
                List<long> ls = new List<long>();
                for (long i = n - 1; i > 0; i--)
                {
                    ls.Add((long)Math.Pow(i, 2));
                }

                ls = BestSum(ls, (long)Math.Pow(n, 2), 0, new List<long>());

                for (int i = ls.Count - 2; i >= 0; i--)
                {
                    result += $"{Math.Sqrt(ls[i])}";
                    if (i > 0) result += " ";
                }
                return result == "" ? null : result;
            }

            private List<long> BestSum(List<long> ls, long n, int k, List<long> worklist)
            {
                if (k == 0) worklist.Clear();

                for (int i = k; i < ls.Count; i++)
                {
                    if (n - ls[i] < 0) continue;
                    else if (n - ls[i] == 0)
                    {
                        worklist.Add(ls[i]);
                        worklist.Add(0);
                        return worklist;
                    }
                    else
                    {
                        worklist.Add(ls[i]);
                        worklist = BestSum(ls, n - ls[i], i + 1 , worklist);
                        if (worklist[worklist.Count - 1] == 0) return worklist;
                        worklist.RemoveAt(worklist.Count - 1);
                    }
                }
                return worklist;
            }
        }
    }
}
