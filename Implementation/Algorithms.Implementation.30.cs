using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{
    static void Main(String[] args)
    {         
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0 && n <= 100)
        {
            Console.WriteLine(Factorial(n));
        }
    }

    private static BigInteger Factorial(int n)
    {
        if (n > 0)
        {
            return BigInteger.Multiply(n , Factorial(n - 1));
        }
        else
        {
            return 1;
        }
    }
}
