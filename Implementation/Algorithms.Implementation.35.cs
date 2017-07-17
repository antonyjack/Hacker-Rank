using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Speech;

class Solution
{
    static void Main(String[] args)
    {
        string[] temp = "10 4".Split(' '); //Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(temp[0]);
        int k = Convert.ToInt32(temp[1]);
        string[] arr_temp = "1 2 3 4 5 6 7 8 9 10".Split(' ');// Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        arr = arr.Where(x => x > 0 && x <= (int)Math.Pow(10, 9)).ToArray();
        int[] result = new int[k];        
        if (n <= (int)Math.Pow(10, 5) && n > 0 && k > 0 && k <= 100)
        {
            for (int i = 0; i < arr.Length; i++)                            
                result[(arr[i] % k)] += 1;
                      
            int count = (int)Math.Min(result[0], 1);            
            for (int i = 1; i <= k/2; i++)
            {
                if (i != k - i)
                    count += (int)Math.Max(result[i], result[k - i]);
            }
            if (k % 2 == 0)
                count += 1;
            Console.WriteLine(count);
        }        
    }
}
