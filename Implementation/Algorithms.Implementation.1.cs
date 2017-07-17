using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int[] solve(int[] grades)
    {        
        for (var i = 0; i < grades.Length; i++)
        {
            int grade = grades[i];            
            if (grade >= 38)
            {
                int rem = grade % 5;
                if (rem != 0)
                {
                    int round = grade + (5 - rem);
                    if (round - grade < 3)
                    {
                        grade = round;
                    }
                }
            }
            grades[i] = grade;
        }
        return grades;
    }

    static void Main(String[] args)
    {        
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int grades_i = 0; grades_i < n; grades_i++)
        {
            grades[grades_i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
