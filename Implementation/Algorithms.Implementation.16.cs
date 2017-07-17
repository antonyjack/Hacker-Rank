using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int Solve(int[][] x)
    {
        int result = int.MaxValue;

        int[] diff = new int[8];
        int[][] s1 = new int[3][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } };
        int[][] s2 = new int[3][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } };
        int[][] s3 = new int[3][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } };
        int[][] s4 = new int[3][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } };
        int[][] s5 = new int[3][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } };
        int[][] s6 = new int[3][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } };
        int[][] s7 = new int[3][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } };
        int[][] s8 = new int[3][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } };
        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < x.Length; j++)
            {
                int s1value = s1[i][j] - x[i][j];
                diff[0] += (int)Math.Abs(s1value);
                int s2value = s2[i][j] - x[i][j];
                diff[1] += Math.Abs(s2value);
                int s3value = s3[i][j] - x[i][j];
                diff[2] += Math.Abs(s3value);
                int s4value = s4[i][j] - x[i][j];
                diff[3] += Math.Abs(s4value);
                int s5value = s5[i][j] - x[i][j];
                diff[4] += Math.Abs(s5value);
                int s6value = s6[i][j] - x[i][j];
                diff[5] += Math.Abs(s6value);
                int s7value = s7[i][j] - x[i][j];
                diff[6] += Math.Abs(s7value);
                int s8value = s8[i][j] - x[i][j];
                diff[7] += Math.Abs(s8value);
            }
        }        
        for (int i = 0; i < diff.Length; i++)
        {
            if (diff[i] < result) { result = diff[i]; }
        }
        return result;
    }


    static void Main(String[] args)
    {
        int[][] s = new int[3][];
        for (int s_i = 0; s_i < 3; s_i++)
        {
            string[] s_temp = Console.ReadLine().Split(' ');
            s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
        }
        //  Print the minimum cost of converting 's' into a magic square
        Console.WriteLine(Solve(s));
    }
}
