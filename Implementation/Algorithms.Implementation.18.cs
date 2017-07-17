using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = "100 100 50 40 40 20 10".Split(' ');//Console.ReadLine().Split(' ');
        int[] scores = Array.ConvertAll(scores_temp, Int32.Parse).Distinct().OrderByDescending(x => x).ToArray();
        //int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = "5 25 50 120".Split(' ');//Console.ReadLine().Split(' ');
        int[] alice = Array.ConvertAll(alice_temp, Int32.Parse).Distinct().OrderBy(x => x).ToArray();
        // your code goes here
        int k = 0;        

        int index = scores.Length - 1;
        for (int i = 0; i < alice.Length; i++)
        {
            for (int j = index; j >= 0; j--)
            {
                var val = scores[j];
                if (alice[i] < scores[j])
                {
                    if (j == scores.Length - 1)
                    {
                        k = j + 2;
                        break;
                    }
                }
                else
                {
                    if (j - 1 < 0)
                    {
                        k = 1;
                        break;
                    }
                    else if (alice[i] == scores[j])
                    {
                        k = j + 1;
                        index = j;
                        break;
                    }
                    else
                    {
                        if (alice[i] >= scores[j - 1])
                            continue;
                        else
                        {
                            k = j + 1;
                            index = j;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(k);
            k = 0;
        }

    }
}
