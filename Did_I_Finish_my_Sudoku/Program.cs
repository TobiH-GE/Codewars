using System;

namespace Did_I_Finish_my_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/53db96041f1a7d32dc0004d2 solution by TobiH

            Console.ReadLine();
        }
    }

    public class Sudoku
    {
        public static string DoneOrNot(int[][] board)
        {
            int[][] tests = new int[][]
                    {
                      new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8},
                      new int[] {0, 9, 18, 27, 36, 45, 54, 63, 72},
                      new int[] {0, 1, 2, 9, 10, 11, 18, 19, 20}
                    };
            int[] testareas = new int[] { 0, 3, 6, 27, 30, 33, 54, 57, 60 };

            for (int t = 0; t < 2; t++)
            {
                int teststartvalue = 0;
                for (int i = 0; i < 9; i++)
                {
                    teststartvalue += 1 << board[tests[t][i] / 9][tests[t][i] % 9] - 1;
                }
                if (teststartvalue != 511) return "Try again!";
            }
            for (int a = 0; a < 9; a++)
            {
                int teststartvalue = 0;
                for (int i = 0; i < 9; i++)
                {
                    teststartvalue += 1 << board[(tests[2][i] + testareas[a]) / 9][(tests[2][i] + testareas[a]) % 9] - 1;
                }
                if (teststartvalue != 511) return "Try again!";
            }

            return "Finished!";
        }
    }
}
