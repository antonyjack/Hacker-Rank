using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int[] getRecord(int[] s)
    {
        int[] result = new int[2];
        int maxLength = 0;
        int minLength = 0;
        int min = 0;
        int max = 0;
        if (s.Length >= 1 && s.Length <= 1000)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 0 && s[i] <= (int)Math.Pow(10, 8))
                {
                    if (i == 0)
                        min = max = s[i];
                    else
                    {
                        if (min > s[i])
                        {
                            min = s[i];
                            minLength++;
                        }

                        if (max < s[i])
                        {
                            max = s[i];
                            maxLength++;
                        }
                    }
                }
            }
        }
        result[0] = maxLength;
        result[1] = minLength;
        return result;
    }

    static void Main(String[] args)
    {
        int n = 6;//Convert.ToInt32(Console.ReadLine());
        string[] s_temp = "0 9 3 10 2 20".Split(' ');//Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
        Console.Read();
    }
}
