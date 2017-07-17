using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int Solve(int[] a)
    {
        List<int> map = Enumerable.Repeat(0, 150).ToList();
        for (int i = 0; i < a.Length; i++)
        {
            var key = a[i];
            map[key]++;
        }

        int maxCount = 0;
        for (int i = 0; i < map.Count - 1; i++)
        {
            var count = map[i] + map[i + 1];
            if (count > maxCount)
                maxCount = count;
        }
        return maxCount;
    }


    static void Main(String[] args)
    {
        Console.WriteLine(Solve(new int[] { 1, 2, 2, 3, 1, 2 }));
        Console.Read();
    }
}
