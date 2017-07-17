using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int solve(int n, string o)
    {
        int result = 0;
        if (n <= (int)Math.Pow(10, 6) && n >= 2)
        {
            int up = 0;            
            char[] ar = o.ToCharArray();
            char start = 'S';            
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == 'U')
                {
                    if (start == 'S')
                        start = 'U';
                    up++;
                }
                else
                {
                    if (start == 'S')
                        start = 'D';
                    up--;
                }

                if (up == 0)
                {
                    up = 0;                    
                    if (start == 'D')
                        result++;
                    start = 'S';
                }
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = 12;//Convert.ToInt32(Console.ReadLine());
        string o = "DDUUDDUDUUUD";//Console.ReadLine();
        int result = solve(n, o);
        Console.WriteLine(result);
        Console.Read();
    }
}
