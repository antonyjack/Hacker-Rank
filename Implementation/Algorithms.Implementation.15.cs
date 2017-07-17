using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static string Solve(int x, int y, int z)
    {
        string result = string.Empty;
        if (x >= 1 && x <= 100 && y >= 1 && y <= 100 && z >= 1 && z <= 100)
        {
            int cat1 = (int)Math.Abs(z - x);
            int cat2 = (int)Math.Abs(z - y);
            if (cat1 < cat2)
                result = "Cat A";
            else if (cat2 < cat1)
                result = "Cat B";
            else
                result = "Mouse C";
        }
        return result;
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        if (q <= 100 && q >= 1)
        {
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);
                Console.WriteLine(Solve(x, y, z));
            }
        }
    }
}
