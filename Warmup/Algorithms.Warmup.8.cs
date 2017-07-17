using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        Console.WriteLine(MinMax(arr));
        Console.Read();
    }

    static string MinMax(int[] arr)
    {
        Int64 min = 0;
        Int64 max = 0;
        for (int i = 0; i < arr.Length; i++) 
        {
            Int64 sumValue = Sum(arr, i);
            if (min == 0)
                min = sumValue;
            if (max == 0)
                max = sumValue;

            min = min < sumValue ? min : sumValue;
            max = max > sumValue ? max : sumValue;

        }
        return min.ToString() + " " + max.ToString();
    }

    static Int64 Sum(int[] arr, int i)
    {
        Int64 sum = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if(i != j)
            {
                sum += arr[j];
            }
        }
        return sum;
    }
}
