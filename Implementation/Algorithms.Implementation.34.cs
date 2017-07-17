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
        int n = 8;// Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = "1 2 3 4 3 3 2 1".Split(' ');// Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        arr = arr.Where(x => x <= 1000 && x > 0).ToArray();
        if (n <= 1000 && n > 0)
        {
            Console.WriteLine(arr.Length);
            bool loop = true;
            while (loop)
            {
                int min = arr.Min(x => x);
                arr = arr.Select(x => x - min).ToArray();
                arr = arr.Where(x => x > 0).ToArray();
                if (arr.Length > 0)
                    Console.WriteLine(arr.Length);
                else
                    loop = false;
            }
        }
    }
}
