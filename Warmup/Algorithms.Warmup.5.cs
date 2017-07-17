using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            Console.WriteLine(Difference(a));            
        }

        static int Difference(int[][] A)
        {
            int primary = 0;
            int secondary = 0;
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = 0; j < A[i].Length; j++)
                {
                    if (i == j)
                    {
                        primary += A[i][j];
                        break;
                    }
                }
                
                int childLoop = 0;
                for (var j = A[i].Length - 1; j >= 0; j--)
                {
                    childLoop++;
                    if (i + 1 == childLoop)
                    {
                        secondary += A[i][j];
                        break;
                    }
                }
            }
            return Math.Abs(primary - secondary);
        }
    }
}
