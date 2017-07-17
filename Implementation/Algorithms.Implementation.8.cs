using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int migratoryBirds(int n, int[] ar)
    {
        int result = 0;
        if (n <= (2 * (int)Math.Pow(10, 5)) && n >= 5)
        {
            int maxCount = 0;            
            for (int i = 1; i <= 5; i++) 
            {
                int count = 0;
                for (int j = 0; j < ar.Length; j++)
                {
                    if (ar[j] >= 1 && ar[j] <= 5)                    
                        if (ar[j] == i)
                            count++;                    
                }

                if (i == 1)
                {
                    maxCount = count;
                    result = i;
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    result = i;
                }
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = 6;//Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = "1 4 4 4 5 3".Split(' ');// Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
        Console.Read();
    }
}
