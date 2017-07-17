using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Display(n);        
    }

    static void Display(int n)
    {
        int print = n;
        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                if (print <= j)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine("");
            print--;
        }
    }
}
