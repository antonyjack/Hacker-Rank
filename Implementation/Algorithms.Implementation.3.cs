using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // Complete this function
        string result = "NO";
        if ((x1 > x2 && v1 > v2) || (x1 < x2 && v1 < v2)
            || (v1 < 0 || v1 > 10000) || (v2 < 0 || v2 > 10000)
            || (x1 < 0 || x1 > 10000) || (x2 < 0 || x2 > 10000))
        {
            return result;
        }
        else
        {            
            while (true)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;                               
                //x1 and x2 values going to negative if max value exceded
                if (x1 > 0 && x1 <= int.MaxValue && x2 > 0 && x2 <= int.MaxValue)
                {
                    if (x1 == x2)
                    {
                        result = "YES";
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }        
    }

    static void Main(String[] args)
    {
        string[] tokens_x1 = "21 6 47 3".Split(' ');//Console.ReadLine().Split(' ');//21 6 47 3//4523 8092 9419 8076
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
